
	printf("\r\nПоследовательная область 1\r\n");
#pragma omp parallel
	{
		printf("Параллельная область\r\n");
	}
	printf("Последовательная область 2\r\n");
