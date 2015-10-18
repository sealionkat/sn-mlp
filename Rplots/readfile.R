readcsv <- function(fileName) {
  return(read.csv(file=fileName, sep=",", dec="."));
}