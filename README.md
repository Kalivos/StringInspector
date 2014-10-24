StringInspector
===============

####Problem
You're working for the Wall Street Journal dotcom, a site that is read by millions across the globe. In your sprint planning meeting, the product manager describes the need to scan through millions of articles and for each article determine the character that occurs the most often. Whaaaat you ask? (don't worry this is a contrived interview question) You'll need to implement a nice simple reuseable method for determining which character occurs the most often in a string. Keep speed and resources in mind. Don't ship bugs!

####Initial thoughts
Wall Street Journal - language encoding?
WSJ is distributed in a variety of languages. Which language encoding should be used? UTF8 should work just fine. Lets run with this and see where we end up.

Storage - The only things needing to be stored is 1) the string to parse & 2) the character/frequency combination. The input data can be stored in a string & the character/frequency combination can be stored in a Hashtable/Dictionary (with the key being the character and the value being the frequency) 

Efficiency - Is it more efficient to sort the list while counting characters vs sorting after all characters have been counted vs running through the list looking for the maximum after all frequencies have been determined (skipping the sort completely)? Max Hashtable size will be determined by distinct characters in article, which means that a sort may be overkill with the limited characters. My instinct is to not use any sorting, but to keep track of the most frequent character while counting.

####Running the program as-is
TBD

####Modifying source input
TBD
