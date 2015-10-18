prepare_classes <- function(input) {
  clX <- list()
  clY <- list();
  classes <- unique(input$cls);
  for (class in classes){
    ind <- which(input$cl == class)
    clX[[class]] <- input$x[ind]
    clY[[class]] <- input$y[ind]
  }
  
  return(list(clX = clX, clY = clY));
}