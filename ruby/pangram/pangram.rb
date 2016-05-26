class Pangram
  VERSION = 1

  def self.is_pangram?(string)
    downcased_string = string.downcase
    ("a".."z").all? { |letter| downcased_string.include?(letter) }
  end
end