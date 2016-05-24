class Fixnum
  VERSION = 1

  ROMANS = {
            M: 1000,
            CM: 900,
            D: 500,
            CD: 400,
            C: 100,
            XC: 90,
            L: 50,
            XL: 40,
            X: 10,
            IX: 9,
            V: 5,
            IV: 4,
            I: 1
          }

  def to_roman
    to_write = self
    output = ""
    ROMANS.each do |roman, number|
      while to_write >= number
        output << roman.to_s
        to_write -= number
      end
    end
    output
  end
end