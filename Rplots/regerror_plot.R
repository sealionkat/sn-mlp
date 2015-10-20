regerror_plot <- function(trX, trY, tX, tY) {
  plot(trX, trY, xlab="Number of Weight Updates", ylab="Error", type="l");
  lines(tX, tY, type="l", lty="dashed");
  text(locator(), labels=c("Training set error", "Test set error"));
}