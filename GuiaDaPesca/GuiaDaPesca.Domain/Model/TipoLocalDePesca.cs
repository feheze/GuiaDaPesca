﻿using System;

namespace GuiaDaPesca.Domain.Model
{
    public class TipoLocalDePesca
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Descricao { get; private set; }

        #endregion

        #region Constructor

        public TipoLocalDePesca(string descricao)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Altera a descricao
        /// </summary>
        public void AlterarDescricao(string descricao)
        {

        }

        #endregion
    }
}