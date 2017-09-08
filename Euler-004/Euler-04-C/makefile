# Compiler
CC := gcc

# Compiler options
CO := -std=c99 -Wall -Werror

main.exe: source.o
	$(CC) -o $@ $<

source.o: source.c
	$(CC) $(CO) -c $<

clean:
	$(RM) *.o *.exe