# using Rscript
# if doesn't work, add Rscript to PATH

args <- commandArgs(trailingOnly = TRUE);
source('setup.R');
source('loadAll.R');

print(args);

errFile <- args[1];
fnFile <- args[2];
trFile <- args[3];

# error plot first...

png(filename="../regression_err.png");
err <- readcsv(errFile);
error_plot(err$it, err$y1, err$it, err$y2);
dev.off();


# ...and then function plot

png(filename="../regression_fun.png");
fn <- readcsv(fnFile);
tr <- readcsv(trFile);
fn_plot(tr$x, tr$y, fn$x, fn$y);
dev.off();