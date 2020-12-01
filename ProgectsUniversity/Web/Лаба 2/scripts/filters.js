const hotels = [
    {
        title : 'The Williamsburg Hotel',
        capacity : 1,
        city : 'New York',
        price : 100,
        id : 'hotel_1'
    },
    {
        title : 'AC Hotel New York Times Square',
        capacity : 2,
        city : 'New York',
        price : 100,
        id : 'hotel_2'
    },
    {
        title : 'Shefah Hotel',
        capacity : 3,
        city : 'New York',
        price : 500,
        id : 'hotel_3'
    },
    {
        title : 'Colonial Traveler',
        capacity : 1,
        city : 'Boston',
        price : 100, 
        id : 'hotel_4'
    },
    {
        title : 'Radisson Hotel Boston',
        capacity : 2,
        city : 'Boston',
        price : 200, 
        id : 'hotel_5'
    },
    {
        title : 'Murphys Resort',
        capacity : 2,
        city : 'Denver',
        price : 500,
        id : 'hotel_6'
    }
];

const all_filters = ['1','2','3','100$','200$','500$','New York','Boston','Denver'];

let active_filters = [];

$(document).ready(function(){
   $(':checkbox').click(function(){
        if ($(this).is(':checked')) {
            active_filters.push($(this).prop('value'));
        }
        else {
            active_filters.splice(active_filters.indexOf($(this).prop('value')), 1);
        }
        changeDisplayedHotels();
    });
});

function changeDisplayedHotels() {
    let num_filters = [];
    let price_filters = [];
    let city_filters = [];

    for (let value of active_filters) {
        if (value.endsWith('$')) {
            price_filters.push(value.slice(0, -1));
        }
        else if (!isNaN(parseInt(value))) {
            num_filters.push(value);
        }
        else {
            city_filters.push(value);
        }
    }

    let validHotelsIds = hotels.filter(hotel => match(hotel, num_filters, price_filters, city_filters))
                                .map(hotel => hotel.id);
    for (let hotel of hotels) {
        if (validHotelsIds.indexOf(hotel.id) > -1) {
            $('#' + hotel.id).show();
        }
        else {
            $('#' + hotel.id).hide();
        }
    }
    correctReviews(validHotelsIds.length);
    disableBadFilters(num_filters, price_filters, city_filters);
}

function match(hotel, num_filters, price_filters, city_filters) {
    if (num_filters.length != 0 && !num_filters.includes(hotel.capacity.toString())) {
        return false;
    }
    if (price_filters.length != 0 && !price_filters.includes(hotel.price.toString())) {
        return false;
    }
    if (city_filters.length != 0 && !city_filters.includes(hotel.city)) {
        return false;
    }
    return true;
}

function disableBadFilters(num_filters, price_filters, city_filters) {
    for (let filter of all_filters) {
        if (!active_filters.includes(filter)) {
            if (filter.endsWith('$')) {
                price_filters.push(filter.slice(0, -1));
            }
            else if (!isNaN(parseInt(filter))) {
                num_filters.push(filter);
            }
            else {
                city_filters.push(filter);
            }
        
            let validHotels = hotels.filter(hotel => match(hotel, num_filters, price_filters, city_filters))
                                        .map(hotel => hotel.id);

            $(`:checkbox[value='${filter}']`).attr('disabled', validHotels.length == 0);

            if (filter.endsWith('$')) {
                price_filters.pop(filter.slice(0, -1));
            }
            else if (!isNaN(parseInt(filter))) {
                num_filters.pop(filter);
            }
            else {
                city_filters.pop(filter);
            }
        }
    }
}

function correctReviews(countValidHotels) {
    if (countValidHotels <= 3) {
        $('.content_3').css('margin-top','570px');
    }
    else {
        $('.content_3').css('margin-top','950px');
    }
}