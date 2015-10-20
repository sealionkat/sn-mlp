error_plot <- function(trX, trY, tX, tY) {
  plot(trX, trY, xlab="Number of Weight Updates", ylab="Error", type="l"); #xlim=c(10, 110)
  lines(tX, tY, type="l", lty="dashed", col="red");
}