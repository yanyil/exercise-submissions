class Complement
  VERSION = 3

  def self.of_dna(strand)
    raise ArgumentError unless self.valid?(strand)
    strand.tr('GCTA', 'CGAU')
  end

  private

  def self.valid?(strand)
    strand.delete('GCTA').empty?
  end
end