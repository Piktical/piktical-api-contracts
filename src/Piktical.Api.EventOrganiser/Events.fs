﻿namespace Piktical.Api.EventOrganiser

module Events =
    open System

    open Piktical.Api.Core.Domain

    type VenueCreated = {
        TimestampUtc: DateTime
        Venue: Venue
    }

    type EventCreated = {
        TimestampUtc: DateTime
        Event: Event
    }

    type EventOccurrencesCreated = {
        TimestampUtc: DateTime
        EventOccurrences: EventOccurrence[]
    }

    type TicketsReleased = {
        TimestampUtc: DateTime
        ReleasedTickets: Ticket[]
    }
