using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class LieutenantGeneral : Private, ILieutenantGeneral
		{
		private readonly List<IPrivate> privates;
		public LieutenantGeneral (int id, string firstname, string lastname, decimal salary)
			: base(id, firstname, lastname, salary)
			{
			this.privates = new List<IPrivate>();
			}

		public IReadOnlyCollection<IPrivate> Privates { get; }

		public void AddPrivate (IPrivate pPrivate)
			{
			this.privates.Add(pPrivate);
			}

		public override string ToString ()
			{

			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.ToString())
				.AppendLine("Privates:");

			foreach (IPrivate item in this.privates)
				{
				sb.AppendLine(" " + item.ToString());
				}

			return sb.ToString().Trim();
			}
		}
	}
