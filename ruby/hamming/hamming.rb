class Hamming
  VERSION = 2

  def self.compute(strand_a, strand_b)
    raise ArgumentError unless strand_a.length == strand_b.length
    (0...strand_a.length).count do |i|
      strand_a[i] != strand_b[i]
    end
  end
end