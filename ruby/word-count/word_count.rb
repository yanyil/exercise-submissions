module BookKeeping
  VERSION = 1
end

class Phrase
  def initialize(phrase)
    @phrase = phrase
  end

  def word_count
    counts = Hash.new(0)
    words.each do |word|
      counts[word] += 1
    end
    counts
  end

  private

  attr_reader :phrase

  def words
    phrase.downcase.scan(/\b[\w+']+\b/)
  end
end