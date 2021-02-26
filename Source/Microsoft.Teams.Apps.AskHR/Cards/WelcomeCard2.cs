// <copyright file="WelcomeCard2.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.AskHR.Cards
{
    using System.Collections.Generic;
    using AdaptiveCards;
    using Microsoft.Bot.Schema;
    using Microsoft.Teams.Apps.AskHR.Bots;
    using Microsoft.Teams.Apps.AskHR.Models;
    using Microsoft.Teams.Apps.AskHR.Properties;

    /// <summary>
    ///  This class process Welcome Card, when bot is installed by the user in personal scope.
    /// </summary>
    public class WelcomeCardPreguntas
    {
        /// <summary>
        /// This method will construct the user welcome card when bot is added in personal scope.
        /// </summary>
        /// <param name="welcomeText">Gets welcome text.</param>
        /// <returns>User welcome card.</returns>
        public static Attachment GetCard(string welcomeText)
        {
            AdaptiveCard userWelcomeCard = new AdaptiveCard("1.0")
            {
                Actions = new List<AdaptiveAction>
                {
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoSacoTurno,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoSacoTurno,
                              Text = AskHRBot.ComoSacoTurno
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoCanceloTurno,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoCanceloTurno,
                              Text = AskHRBot.ComoCanceloTurno
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.QueHagoRetire,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.QueHagoRetire,
                              Text = AskHRBot.QueHagoRetire
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.QuePuedoRetirar,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.QuePuedoRetirar,
                              Text = AskHRBot.QuePuedoRetirar
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoTrasladoEdificio,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoTrasladoEdificio,
                              Text = AskHRBot.ComoTrasladoEdificio
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoReservoCochera,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoReservoCochera,
                              Text = AskHRBot.ComoReservoCochera
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoSolicitoTaxi,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoSolicitoTaxi,
                              Text = AskHRBot.ComoSolicitoTaxi
                            }
                        },
                    },                   
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoGenerousuario,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoGenerousuario,
                              Text = AskHRBot.ComoGenerousuario
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.ComoTiempo,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.ComoTiempo,
                              Text = AskHRBot.ComoTiempo
                            }
                        },
                    },
                    new AdaptiveSubmitAction
                    {
                        Title = AskHRBot.PuedoSolicitar,
                        Data = new TeamsAdaptiveSubmitActionData
                        {
                            MsTeams = new CardAction
                            {
                              Type = ActionTypes.MessageBack,
                              DisplayText = AskHRBot.PuedoSolicitar,
                              Text = AskHRBot.PuedoSolicitar
                            }
                        },
                    }
                    
                }
            };

            return new Attachment
            {
                ContentType = AdaptiveCard.ContentType,
                Content = userWelcomeCard,
            };
        }
    }
}