class Gigasecond
  VERSION = 1
  GIGASECONDS = 10**9

  def self.from(date)
    date + GIGASECONDS
  end
end