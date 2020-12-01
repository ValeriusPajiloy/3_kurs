const rooms = [
    {
        title : 'Business room',
        capacity : 1,
        floor : 'first_floor',
        price : 50,
        id : 'room_1'
    },
    {
        title : 'Double business room',
        capacity : 2,
        floor : 'first_floor',
        price : 100,
        id : 'room_2'
    },
    {
        title : 'Comfort room',
        capacity : 1,
        floor : 'second_floor',
        price : 100,
        id : 'room_3'
    },
    {
        title : 'Comfort room with balcony',
        capacity : 1,
        floor : 'second_floor',
        price : 100, 
        id : 'room_4'
    },
    {
        title : 'Double comfort room',
        capacity : 2,
        floor : 'third_floor',
        price : 150, 
        id : 'room_5'
    },
    {
        title : 'Family comfort room with balcony',
        capacity : 3,
        floor : 'third_floor',
        price : 150,
        id : 'room_6'
    }
];

const all_filters = ['1','2','3','50$','100$','150$','first_floor','second_floor','third_floor'];

let active_filters = [];
let current_object =[];
$(document).ready(function(){
   $(':checkbox').click(function(){
        if ($(this).is(':checked')) {
            active_filters.push($(this).prop('value'));
        }
        else {
            active_filters.splice(active_filters.indexOf($(this).prop('value')), 1);
        }
        changeDisplayedrooms();
    });
});

function changeDisplayedrooms() {
    let num_filters = [];
    let price_filters = [];
    let floor_filters = [];

    for (let value of active_filters) {
        if (value.endsWith('$')) {
            price_filters.push(value.slice(0, -1));
        }
        else if (!isNaN(parseInt(value))) {
            num_filters.push(value);
        }
        else {
            floor_filters.push(value);
        }
    }

    let validroomsIds = rooms.filter(room => match(room, num_filters, price_filters, floor_filters)) 
                                .map(room => room.id);
    current_object = validroomsIds;
    for (let room of rooms) {
        if (validroomsIds.indexOf(room.id) > -1) {
            $('#' + room.id).show();
        }
        else {
            $('#' + room.id).hide();
        }
    }
    disableBadFilters(num_filters, price_filters, floor_filters);
}

function match(room, num_filters, price_filters, floor_filters) {
    if (num_filters.length != 0 && !num_filters.includes(room.capacity.toString())) {
        return false;
    }
    if (price_filters.length != 0 && !price_filters.includes(room.price.toString())) {
        return false;
    }
    if (floor_filters.length != 0 && !floor_filters.includes(room.floor)) {
        return false;
    }
    return true;
}

function disableBadFilters(num_filters, price_filters, floor_filters) {
    for (let filter of all_filters) {
        if (!active_filters.includes(filter)) {
            if (filter.endsWith('$')) {
                price_filters.push(filter.slice(0, -1));
            }
            else if (!isNaN(parseInt(filter))) {
                num_filters.push(filter);
            }
            else {
                floor_filters.push(filter);
            }
        
            let validrooms = rooms.filter(room => match(room, num_filters, price_filters, floor_filters)).map(room => room.id);
            
            $(`:checkbox[value='${filter}']`).attr('disabled', (validrooms.length == 0)||(isSame(validrooms,current_object)) );

            if (filter.endsWith('$')) {
                price_filters.pop(filter.slice(0, -1));
            }
            else if (!isNaN(parseInt(filter))) {
                num_filters.pop(filter);
            }
            else {
                floor_filters.pop(filter);
            }
        }
    }
}

function isSame(valid, current){
    let i = 0;
    while(valid.length > i){
        if (valid[i]!==current[i]) return false;
        i++;
    }
    return true;
}