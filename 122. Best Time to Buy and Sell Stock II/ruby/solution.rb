prices1 = Array[7, 1, 5, 3, 6, 4]

prices2 = Array[1, 2, 3, 4, 5]

prices3 = Array[7, 6, 4, 3, 1]

# @param {Integer[]} prices
# @return {Integer}
def max_profit(prices)
    profit = 0
    prices.each_with_index do |v,i|
      if prices[i + 1] && prices[i + 1] > v
        profit += prices[i + 1] - v
      end
    end
    profit
end

puts max_profit(prices1)
puts max_profit(prices2)
puts max_profit(prices3)
