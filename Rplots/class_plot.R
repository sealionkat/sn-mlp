# Plot of classes of training set and test set
#
# Parameters:
#   - trX: Xs for training set
#   - trY: Ys for training set
#   - tX: Xs for test set
#   - tY: Ys for test set
#   - minX: min value for X axis
#   - maxX: max value for X axis
#   - minY: min value for Y axis
#   - maxY: max value for X axis

class_plot <- function(trX, trY, tX, tY, minX=-1, maxX=1, minY=-1, maxY=1) {
  clCount <- length(trX);
  
  bgcolors <- brewer.pal(clCount, 'Pastel1');
  colors <- brewer.pal(clCount, 'Set1');
  plot(NA, NA, xlab="X", ylab="Y", xlim=c(minX, maxX), ylim=c(minY, maxY));
  
  for(i in 1:clCount) {
    points(tX[[i]], tY[[i]], cex=0.01, col=bgcolors[[i]]);
  }
  
  for(i in 1:clCount) {
    points(trX[[i]], trY[[i]], col=colors[[i]]);
  }
} 