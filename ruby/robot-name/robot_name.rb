class Robot
  VERSION = 1

  attr_reader :name

  @taken_names = []

  def name
    @name ||= generate_name
  end

  def reset
    @name = nil
  end

  def self.taken_names
    @taken_names
  end

  private

  def generate_name
    name = generate_letters + generate_number
    if self.class.taken_names.include? name
      name = generate_name
    end
    self.class.taken_names << name
    name
  end

  def generate_letters
    [*('A'..'Z')].sample(2).join
  end

  def generate_number
    rand.to_s[2..4]
  end
end