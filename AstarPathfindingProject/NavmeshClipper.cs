using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public abstract class NavmeshClipper : VersionedMonoBehaviour
	{
		// Token: 0x060007C6 RID: 1990 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x6CC0F0", Offset = "0x6CA6F0", VA = "0x1806CC0F0")]
		public static void AddEnableCallback(Action<NavmeshClipper> onEnable, Action<NavmeshClipper> onDisable)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x6CC340", Offset = "0x6CA940", VA = "0x1806CC340")]
		public static void RemoveEnableCallback(Action<NavmeshClipper> onEnable, Action<NavmeshClipper> onDisable)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000136")]
		public static List<NavmeshClipper> allEnabled
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x6CC590", Offset = "0x6CAB90", VA = "0x1806CC590")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x6CC5E0", Offset = "0x6CABE0", VA = "0x1806CC5E0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x6CC720", Offset = "0x6CAD20", VA = "0x1806CC720", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060007CB RID: 1995
		[Token(Token = "0x60007CB")]
		internal abstract void NotifyUpdated();

		// Token: 0x060007CC RID: 1996
		[Token(Token = "0x60007CC")]
		public abstract Rect GetBounds(GraphTransform transform);

		// Token: 0x060007CD RID: 1997
		[Token(Token = "0x60007CD")]
		public abstract bool RequiresUpdate();

		// Token: 0x060007CE RID: 1998
		[Token(Token = "0x60007CE")]
		public abstract void ForceUpdate();

		// Token: 0x060007CF RID: 1999 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x6CC8F0", Offset = "0x6CAEF0", VA = "0x1806CC8F0")]
		protected NavmeshClipper()
		{
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x0")]
		private static Action<NavmeshClipper> OnEnableCallback;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x8")]
		private static Action<NavmeshClipper> OnDisableCallback;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<NavmeshClipper> all;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x28")]
		private int listIndex;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x2C")]
		public GraphMask graphMask;
	}
}
