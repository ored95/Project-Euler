#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define L_BORDER 100000
#define R_BORDER 998001
#define MIN_RANGE 101
#define MAX_RANGE 1000

int __palindrome(const int number)
{
	char str[6];
	sprintf(str, "%d", number);	// convert number to a string
	return (str[0] == str[5]) && (str[1] == str[4]) && (str[2] == str[3]);
}

int __accept(const int number)
{
	
	int _sqrt = (int)sqrt(number);
	int flag = 0, i = MIN_RANGE;
	while (i++ <= _sqrt)
	{
		if (number % i == 0)
		{
			if (number / i < MAX_RANGE)
			{
				flag = i;
				break;
			}
		}
	}
	
	return flag;
}

int main(int argc, char **argv)
{
	if (argc < 2)
		return -1;
	
	int n = atoi(argv[1]);
	if (n > R_BORDER)
		n = R_BORDER;
	
	int key = 0;
	while (n-- > L_BORDER)
	{
		if (__palindrome(n))
		{
			if ((key = __accept(n)))
				break;
		}
	}
	
	if (n > L_BORDER)
		printf("\nResult: %d (%d x %d)\n", n, key, n / key);
	else
		printf("\nResult: Not found!\n");
	
	return 0;
}