class Raindrops
  VERSION = 1

  def self.convert(number)
    new(number).convert
  end

  attr_reader :number

  def initialize(number)
    @number = number
  end

  def convert
    output = ""
    output << "Pling" if divisible?(3)
    output << "Plang" if divisible?(5)
    output << "Plong" if divisible?(7)
    output = number.to_s if output.empty?
    output
  end

  private

  def divisible?(factor)
    number % factor == 0
  end
end