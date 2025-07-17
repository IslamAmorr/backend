using Domain.DTOs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Hubs
{
    public class AlertHub : Hub
    {
        /// <summary>
        /// Rejoindre le groupe d'un équipement (pour recevoir ses alertes).
        /// </summary>
        public Task JoinGroup(string equipment) =>
            Groups.AddToGroupAsync(Context.ConnectionId, equipment);

        /// <summary>
        /// Quitter le groupe d'un équipement.
        /// </summary>
        public Task LeaveGroup(string equipment) =>
            Groups.RemoveFromGroupAsync(Context.ConnectionId, equipment);

    }
}
