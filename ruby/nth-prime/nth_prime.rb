class Prime
  def self.nth(n)
    raise ArgumentError if n < 1
    counter = 0
    number = 1
    while counter < n
      number += 1
      counter += 1 unless composite?(number)
    end
    number
  end

  def self.composite?(n)
    (2..Math.sqrt(n)).any? do |i|
      n % i == 0
    end
  end
  private_class_method :composite?
end