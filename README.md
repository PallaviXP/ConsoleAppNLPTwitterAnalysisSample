# ConsoleAppNLPTwitterAnalysisSample
NLP sample for sentiment analysis using SimpleNetNLP, VADER library and google cloud api for NLP

Introduction
If you want to understand people, especially your customers…then you have to be able to possess a strong capability to analyze text. 
 
Natural language processing (NLP) is the ability of a computer program to understand human language as it is spoken. NLP is a component of artificial intelligence. 
When to use NLP
1.	To Classify documents
2.	Sentiment analysis 
This measures inclination of people opinion e.g. Score text for sentiments/to see positive or negative tone.
3.	Syntactic analysis 
This extracts linguistic information e.g. tagging part of speech, chunking, parsing.
4.	Getting Semantic information 
E.g. word-sense disambiguation, semantic role labeling, named entity extraction, summarizing text by identifying entities in document.
5.	Entity Analysis 
E.g. inspects the given information for entities by searching for proper nouns such as public figures, landmarks, etc., and returns information about those entities.
6.	Use free text, interpret it and make it analyzable 


#POC 1 – Real time Sentiment Analysis sample Using SimpleNetNlp Library

Introduction of SimpleNetNlp
SimpleNetNlp is based on Simple CoreNLP that provides a simple API for users who do not need a lot of customization. SimpleNetNLP is c# wrapper for Stannford Core NLP. 

https://nlp.stanford.edu/software/  Stanford CoreNLP provides a set of human language technology tools. It can give the base forms of words, their parts of speech, whether they are names of companies, people, etc., normalize dates, times, and numeric quantities, mark up the structure of sentences in terms of phrases and syntactic dependencies, indicate which noun phrases refer to the same entities, indicate sentiment, extract particular or open-class relations between entity mentions, get the quotes people said, etc.

Choose Stanford CoreNLP if you need:
•	An integrated NLP toolkit with a broad range of grammatical analysis tools
•	A fast, robust annotator for arbitrary texts, widely used in production
•	A modern, regularly updated package, with the overall highest quality text analytics
•	Support for a number of major (human) languages
•	Available APIs for most major modern programming languages
•	Ability to run as a simple web service


POC Steps (Project name: - ConsoleAppNLPStanford)
1.	Created Twitter developer account, get access keys to connect to the account.
2.	Added below dependencies
a.	TweetInviAPI
b.	SimpleNetNlp
c.	SimpleNetNlp.Models.LexParser
d.	SimpleNetNlP.Models.Sentiment
3.	Created console application
4.	Connected to twitter account using access tokens
5.	Observed some hashtags, and subscribe for those tags match event
6.	And analyzed the sentiment of statement when match event fired.
Technology/Tools used
•	.Net Framework 4.6.1
•	Twitter API
•	SimpleNetNlp library


#POC 2 - Real time Sentiment Analysis sample Using VADER Library
Introduction of VADER
VADER (Valence Aware Dictionary and sEntiment Reasoner) is a lexicon and rule-based sentiment analysis tool that is specifically attuned to sentiments expressed in social media. It is fully open-sourced under the [MIT License].
Dependency :- CodingUpAStorm.VaderSharp
For this sample also created twitter account as above steps and analyzed the tweet using VADER library.
Project name:- ConsoleAppNLPVADERSampleNetCore
Technology/Tools used
•	.Net Core 4.6.1
•	Twitter API
•	VADER library

#POC 3 - Real time Sentiment Analysis sample using Google Cloud NLP API

Introduction
NLP google cloud API provides below services.
Sentiment analysis 
This measures inclination of people opinion. The Score of the sentiment ranges between -1.0 (negative) and 1.0 (positive) and corresponds to the overall sentiment from the given information. The Magnitude of the sentiment ranges from 0.0 to +infinity and indicates the overall strength of sentiment from the given information. The more information that is provided the higher the magnitude.
Entity analysis
Entity analysis inspects the given information for entities by searching for proper nouns such as public figures, landmarks, etc., and returns information about those entities.
Syntax analysis
Syntactic Analysis extracts linguistic information, breaking up the given text into a series of sentences and tokens (generally, word boundaries), providing further analysis on those tokens.
About POC
POC is done only for sentiment analysis. Steps are as below
1.	Need to use Google cloud shell and enable NLP API
2.	Authenticate API request
3.	 install the Google Cloud client library for C#
4.	can perform Sentiment Analysis – 
5.	can perform Entity Analysis
6.	can perform Syntax Analysis

Technology/Tools used
•	.Net Framework 4.6.1
•	Twitter API
•	VADER library

#Reference Links
http://luisquintanilla.me/2018/01/18/real-time-sentiment-analysis-csharp/ 

https://github.com/cjhutto/vaderSentiment 

https://console.cloud.google.com/cloud-resource-manager 

https://codelabs.developers.google.com/codelabs/cloud-natural-language-csharp/index.html?index=..%2F..%2Findex#0 


