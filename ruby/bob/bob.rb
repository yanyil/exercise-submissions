class Bob
  def hey(remark)
    return "Fine. Be that way!" if silence?(remark)
    return "Whoa, chill out!" if shout?(remark)
    return "Sure." if question?(remark)
    "Whatever."
  end

  private

  def question?(remark)
    remark.end_with?("?")
  end

  def shout?(remark)
    remark == remark.upcase && remark =~ /[A-Z]/
  end

  def silence?(remark)
    remark.strip.empty?
  end
end