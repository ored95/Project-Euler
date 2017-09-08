class Factors:
    number = 1
    max_factor = 1

    def __init__(self, n):
        self.number = n

    def search_prime_factor(self):
        n = self.number
        j = self.max_factor + 1

        while j <= n:
            if n % j == 0:
                break
            j += 1

        while n % j == 0:
            n /= j

        self.number = n
        self.max_factor = j

    def search_largest_prime_factor(self):
        while self.number > 1:
            self.search_prime_factor()

test = Factors(int(input("Input number N: ")))
test.search_largest_prime_factor()
print("The largest prime factor is %d" % (test.max_factor))
