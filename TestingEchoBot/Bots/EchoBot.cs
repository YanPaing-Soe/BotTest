// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.6.2

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace TestingEchoBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        //protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        //{
        //    var replyText = $"Echo: {turnContext.Activity.Text}";
        //    await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        //}

        //protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        //{
        //    if (string.Equals(turnContext.Activity.Text, "wait", System.StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        await turnContext.SendActivitiesAsync(
        //            new Activity[] {
        //        new Activity { Type = ActivityTypes.Typing },
        //        new Activity { Type = "delay", Value= 3000 },
        //        MessageFactory.Text("Finished typing", "Finished typing"),
        //            },
        //            cancellationToken);
        //    }
        //    if (string.Equals(turnContext.Activity.Text, "hi", System.StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        var replyText = $"Echo: Mingalarpar";
        //        await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        //    }
        //    else
        //    {
        //        var replyText = $"Echo: {turnContext.Activity.Text}. Say 'wait' to watch me type.";
        //        await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        //    }
        //}

        //protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        //{
        //    var card = new HeroCard
        //    {
        //        Text = "You can upload an image or select one of the following choices",
        //        Buttons = new List<CardAction>
        //{
        //    // Note that some channels require different values to be used in order to get buttons to display text.
        //    // In this code the emulator is accounted for with the 'title' parameter, but in other channels you may
        //    // need to provide a value for other parameters like 'text' or 'displayText'.
        //    new CardAction(ActionTypes.ImBack, title: "1. Inline Attachment", value: "1"),
        //    new CardAction(ActionTypes.ImBack, title: "2. Internet Attachment", value: "2"),
        //    new CardAction(ActionTypes.ImBack, title: "3. Uploaded Attachment", value: "3"),
        //},
        //    };

        //    var reply = MessageFactory.Attachment(card.ToAttachment());
        //    await turnContext.SendActivityAsync(reply, cancellationToken);
        //}

        //protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        //{
        //    var reply = MessageFactory.Text("What is your favorite color?");

        //    reply.SuggestedActions = new SuggestedActions()
        //    {
        //        Actions = new List<CardAction>()
        //{
        //    new CardAction() { Title = "Red", Type = ActionTypes.ImBack, Value = "Red" },
        //    new CardAction() { Title = "Yellow", Type = ActionTypes.ImBack, Value = "Yellow" },
        //    new CardAction() { Title = "Blue", Type = ActionTypes.ImBack, Value = "Blue" },
        //},
        //    };
        //    await turnContext.SendActivityAsync(reply, cancellationToken);
        //}

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome!";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }


        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {

            if (isStartMessages(turnContext.Activity.Text))
            {
                var attachments = new List<Attachment>();
                var cardOne = new HeroCard
                {
                    Title = "Find by category",
                    Text = "Description for product information will be provided here",
                    Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                    Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.ImBack, title: "See categories", value: "See categories"),
        },
                };
                var cardTwo = new HeroCard
                {
                    Title = "Find by shop",
                    Text = "Description for product information will be provided here",
                    Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                    Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.ImBack, title: "See shops", value: "See shops"),
        },
                };
                attachments.Add(cardOne.ToAttachment());
                attachments.Add(cardTwo.ToAttachment());

                var reply = MessageFactory.Attachment(attachments);
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (isFromStepOne(turnContext.Activity.Text))
            {
                if (string.Equals(turnContext.Activity.Text, "See categories", System.StringComparison.InvariantCultureIgnoreCase))
                {
                    var attachments = new List<Attachment>();
                    var cardOne = new HeroCard
                    {

                        Title = "Phone",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.ImBack, title: "About this", value: "About this"),
            new CardAction(ActionTypes.ImBack, title: "See product", value: "See product"),

        },
                    };
                    var cardTwo = new HeroCard
                    {
                        Title = "Electronic",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

             new CardAction(ActionTypes.ImBack, title: "About this", value: "About this"),
            new CardAction(ActionTypes.ImBack, title: "See product", value: "See product"),
        },
                    };
                    attachments.Add(cardOne.ToAttachment());
                    attachments.Add(cardTwo.ToAttachment());

                    var reply = MessageFactory.Attachment(attachments);
                    await turnContext.SendActivityAsync(reply, cancellationToken);

                }
                else if (string.Equals(turnContext.Activity.Text, "See shops", System.StringComparison.InvariantCultureIgnoreCase))
                {
                    var attachments = new List<Attachment>();
                    var cardOne = new HeroCard
                    {
                        Title = "Samsung",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.OpenUrl, title: "About this", value: "www.google.com"),
            new CardAction(ActionTypes.ImBack, title: "See product", value: "See product"),

        },
                    };
                    var cardTwo = new HeroCard
                    {
                        Title = "H&M",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

             new CardAction(ActionTypes.OpenUrl, title: "About this", value: "www.google.com"),
            new CardAction(ActionTypes.ImBack, title: "See product", value: "See product"),
        },
                    };
                    attachments.Add(cardOne.ToAttachment());
                    attachments.Add(cardTwo.ToAttachment());

                    var reply = MessageFactory.Attachment(attachments);
                    await turnContext.SendActivityAsync(reply, cancellationToken);

                }
                else
                {
                    var replyText = $"Echo: I am about";
                    await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
                }

            }

            else if (isFromStepTwo(turnContext.Activity.Text))
            {
                {
                    var attachments = new List<Attachment>();
                    var cardOne = new HeroCard
                    {
                        Title = "Your Product",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.OpenUrl, title: "More information", value: "www.google.com"),
            new CardAction(ActionTypes.OpenUrl, title: "Order now", value: "www.google.com"),
            new CardAction(ActionTypes.OpenUrl, title: "Contact us", value: "www.google.com"),
        },
                    };
                    var cardTwo = new HeroCard
                    {
                        Title = "Your Product",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.OpenUrl, title: "More information", value: "www.google.com"),
            new CardAction(ActionTypes.OpenUrl, title: "Order now", value: "www.google.com"),
            new CardAction(ActionTypes.OpenUrl, title: "Contact us", value: "www.google.com"),
        },
                    };
                    var cardThree = new HeroCard
                    {
                        Title = "Your Product",
                        Text = "Description for product information will be provided here",
                        Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                        Buttons = new List<CardAction>
        {

            new CardAction(ActionTypes.OpenUrl, title: "More information", value: "www.google.com"),
            new CardAction(ActionTypes.OpenUrl, title: "Order now", value: "www.google.com"),
            new CardAction(ActionTypes.OpenUrl, title: "Contact us", value: "www.google.com"),
        },
                    };
                    attachments.Add(cardOne.ToAttachment());
                    attachments.Add(cardTwo.ToAttachment());
                    attachments.Add(cardThree.ToAttachment());

                    var reply = MessageFactory.Attachment(attachments);
                    await turnContext.SendActivityAsync(reply, cancellationToken);

                }
            }
        }

        public bool isStartMessages(string text)
        {
            var keywords = new List<string> { "hello", "hi", "mingalarpar" };
            return keywords.Contains(text);
        }

        public bool isFromStepOne(string text)
        {
            var keywords = new List<string> { "See categories", "See shops" };
            return keywords.Contains(text);
        }

        public bool isFromStepTwo(string text)
        {
            var keywords = new List<string> { "See product", };
            return keywords.Contains(text);
        }

    }
}
