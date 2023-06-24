using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000005")]
		public event Action onDestroyed
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2830B10", Offset = "0x282F110", VA = "0x182830B10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x2830C00", Offset = "0x282F200", VA = "0x182830C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000013")]
		protected VertexPath path
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2830CF0", Offset = "0x282F2F0", VA = "0x182830CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2830D10", Offset = "0x282F310", VA = "0x182830D10")]
		public void TriggerUpdate()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x282D840", Offset = "0x282BE40", VA = "0x18282D840", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		protected abstract void PathUpdated();

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
		protected PathSceneTool()
		{
		}

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		public PathCreator pathCreator;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x30")]
		public bool autoUpdate;
	}
}
