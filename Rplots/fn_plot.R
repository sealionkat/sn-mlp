# Plot of training set and test set
#
# Parameters:
#   - trX: Xs for training set
#   - trY: Ys for training set
#   - tX: Xs for test set
#   - tY: Ys for test set

fn_plot <- function(trX, trY, tX, tY) {
  plot(trX, trY, main="Wartosc funkcji", xlab="X", ylab="Y", type="p", col="black");
  lines(tX, tY, col="red", lwd=2);
} 