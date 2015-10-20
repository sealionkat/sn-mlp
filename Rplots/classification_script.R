# using Rscript
# if doesn't work, add Rscript to PATH

args <- commandArgs(trailingOnly = TRUE);
source('setup.R');
source('loadAll.R');

print(args);

errFile <- args[1];
fnFile <- args[2];

# error plot first...

png(filename="../classification_err.png");
err <- readcsv(errFile);
error_plot(err$it, err$y1, err$it, err$y2);
dev.off();


# ...and then function plot

#png(filename="classification_fun.png");

#dev.off();