import os, sys
import json
import scipy.stats
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt


with open("test") as file:
    js = json.load(file)
if not os.path.exists("output"):
    os.mkdir("output")

cdf = pd.read_csv(js["calibration_data"])

cx, cy = cdf["x"], cdf["y"]

res = scipy.stats.linregress(np.array(cx), y=np.array(cy))

tdf = pd.read_csv(js["test_data"])
tx = tdf["x"]

def predict(x):
    return res.intercept + res.slope*np.array(x)

ty = predict(tx)

tdf = pd.DataFrame.from_dict({"x" : tx, "y" : ty})
tdf.to_csv("output/predicted.csv", index=None)



ts = np.linspace(min(cx), max(cx))
plt.plot(ts, predict(ts), '--', color='tab:blue')
plt.scatter(cx, cy)
plt.scatter(tx, ty)
plt.title("Regression for project '{}'".format(js["name"]))

plt.savefig("C:/Users/carva/Documents/GitHub/plot.png")



