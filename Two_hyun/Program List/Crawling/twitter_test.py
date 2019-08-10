from twitter import *

t = Twitter(auth=OAuth("", #Access Token
                       "", #Access Token Secret
                       "", #Consumer Key
                       "")) #Consumer Secret
pythonTweets = t.statuses.user_timeline(screen_name="realDonaldTrump", count=5)
#pythonTweets = t.statuses.home_timeline()
print(pythonTweets)