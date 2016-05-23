class Pangram
  VERSION = 1

  def self.is_pangram?(string)
    ("a".."z").all? { |letter| string.downcase.include?(letter) }
  end
end