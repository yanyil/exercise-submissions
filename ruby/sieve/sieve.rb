class Sieve
  attr_reader :limit

  def initialize(limit)
    @limit = limit
  end

  def primes
    @primes ||= sieve
  end

  private

  def sieve
    list = (2..limit).to_a
    primes = []
    until list.empty?
      number = list.shift
      primes << number
      list.reject! { |n| n % number == 0 }
    end
    primes
  end
end