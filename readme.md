# Qbert
The below is part of a draft blog post for https://isaacwyatt.com

# Summary / TLDR
In 2010 [I coded a program I called "Qbert"](https://github.com/iwyatt/Qbert) (in homage to the [character](https://en.wikipedia.org/wiki/Q*bert) of a similarly named [arcade game](https://freeqbert.org/)) in C# to quickly and easily load a CSV file of people into the marketing automation tool's database, including formatting the data, applying normalization methods, and removing erroneous and duplicitous entries. 

 >[!warning]- Intellectual Property
>No one has ever hired me to write code or develop intellectual property. My job titles have nearly all been of the "Strategy and Operations" variety which is usually strictly execution of other internal team's priorities. No job description I've ever signed an offer for included any requirements to develop code. At the time I'd written this software, I'd never worked for a company that required an intellectual property ownership agreement of me. This software clearly had no marketable value as not a single person ever requested to download it and use it themselves. Additionally, any software I wrote in such a capacity was never sold or distributed for compensation.

# Background
In the 2009 - 2010 time frame, the company I worked at often worked with media websites to distribute content (eg: "thought leadership" white papers) that was gated behind web forms. People who filled out such a web form was considered a sales lead. It was my job to take the list of leads generated from these forms, process them, and insert them into our marketing automation platform's database at which point, they would be scored and distributed to sales people to follow up. We used [Eloqua](https://www.oracle.com/cx/marketing/automation/) as our marketing automation platform at the time.

# Problem
As it was my job to manually, painstakingly, **thoroughly**, and **accurately**, load these "leads" for sales people to follow up on (and by proxy to keep the marketers happy), I had to **quickly** process the files (usually delivered in CSV or XLS format) within a short turn-around time once delivered to me. 

One can imagine that doing manual repetitive, high urgency, detailed work of formatting data in spreadsheets is an endeavor not sustainable by an individual for long. Additionally, despite my best intentions of producing high quality work, errors would of course happen occasionally and coworkers from both marketing and sales would let me know - and not always in empathetic ways.

Our company, its marketers and sales people, our vendors who distributed our content, and even the "leads" themselves would all be better served if I streamlined and automated my portion of the process to the extent I could. More value could be delivered faster by cutting entire **days** out of the time from when a person filled out a web form to when they received a follow up email or phone call from one of our sales people - especially considering the **thousands** of "leads" contained in each spreadsheet. Additionally, my own capacity could be freed up to focus on other higher-value activities.

# Solution
I coded a C# desktop application I called "Qbert" to open a CSV file, format its contents according to rules specified by our marketing automation platform, remove erroneous and duplicative entries, and deliver the CSV's entries in to the marketing automation database. 

Each CSV contained rows that contained a person's information who filled out a form on our media partner's website. Not only did the column headers need to be modified to match what our systems expected, but the length of the contents of the fields needed to be truncated to acceptable values as well. Phone numbers needed to be formatted and duplicate rows needed to be removed. 

Qbert provided an easy to use and 2-click interface to do the above data cleansing activities. It also posted each row representing a "lead" to the marketing automation platform and displayed the results of each row's insertion. This happened in an interactive and user-friendly desktop application.

# Impact
By streamlining and automation most of the activities between the input and output I was responsible for, we more quickly delivered "leads" to sales people, kept marketers happy, and prospects received follow-ups in a more timely way generated more revenue pipeline for the company - and probably more bonuses to my marketing peers.

Additionally, I saved myself hundreds of hours of future work by not having to do the manual work any more, and the optionality to work on higher-value work allowed me to add more value to the company.

I'd estimate that hundreds of thousands of dollars of value, if not millions, was created based on the frequency of spreadsheets, volume of "leads" in each spreadsheet, and reducing the turn-around time from **days** to **minutes**.

# Known Limitations
The version of Qbert I reviewed for this post does not have the mappings or data normalizations I thought I implemented to automatically encode values from how the Vendor collected certain data (eg the number of employees in a "lead"'s company) to how our marketing automation platform expected the same data. I also thought I implemented automated geographic information enrichment but I do not see that in this version.

Today, it should also go without saying that neither Eloqua, the media partners involved, nor my former company have the systems in place that would either use this tool, support it, or accept its output. As such, it is currently not useful software for such purposes.

The personal impact of developing and deploying this solution has created optionality through the development of skills that can be applied in all functions of an organization like Marketing, Sales, etc.

# Alternative Solutions
Alternative solutions available at the time included asking a consultancy we had on retainer at the time, to build such a tool. Indeed they did provide a basic php based uploaded, but was hindered in value due to the lack of data scrubbing processes that I implemented in Qbert. We could also have hired a junior person to process the spreadsheets, and at various times, I did have interns and temp employees to help do these activities. 

# Further Development
At the time, further development could have included templates or profiles to extend its usage to any arbitrary media partner or Eloqua user. However, as Qbert was never intended to be used outside of the org, I never considered this. 

Additionally, this could have been set up to be a hosted service, completely automating an input from a media partner, and posting the results to the marketing automation platform. Although having a person-in-the-middle using Qbert to post the "leads" allowed for continual refinement of Qbert and its capabilities.

Today, no further development for Qbert will be or should be considered as the entire ecosystem and environment in which it was intended to operate has changed. 

# Conclusion
Highly manual and repetitive processes and tasks that are high impact and value can add even more value if automated with a person-in-the-middle. [Qbert](https://github.com/iwyatt/Qbert) solved a real pain point and delivered exceptional ROI for my time-value, not just freeing up my own capacity, but also delivering increased value to my company at the time in both marketing and sales.

