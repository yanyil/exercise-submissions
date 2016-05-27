class Prime
  def self.nth(n)
    raise ArgumentError if n < 1
    counter = 0
    number = 1
    while counter < n
      number += 1
      counter += 1 if self.prime?(number)
    end
    number
  end

  private

  def self.prime?(n)
    (2..Math.sqrt(n)).each do |i|
      return false if n % i == 0
    end
    true
  end
end