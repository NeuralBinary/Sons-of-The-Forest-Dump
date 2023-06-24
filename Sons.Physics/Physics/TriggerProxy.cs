using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class TriggerProxy : MonoBehaviour
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		private event Action<Collider> TriggerEnterEvent
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x3108000", Offset = "0x3106600", VA = "0x183108000")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x3108170", Offset = "0x3106770", VA = "0x183108170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		private event Action<Collider> TriggerExitEvent
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x31082E0", Offset = "0x31068E0", VA = "0x1831082E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x3108450", Offset = "0x3106A50", VA = "0x183108450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		private event Action<Collider> TriggerStayEvent
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x31085C0", Offset = "0x3106BC0", VA = "0x1831085C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x3108730", Offset = "0x3106D30", VA = "0x183108730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3108000", Offset = "0x3106600", VA = "0x183108000")]
		public void RegisterOnTriggerEnterCallback(Action<Collider> triggerAction)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3108170", Offset = "0x3106770", VA = "0x183108170")]
		public void UnregisterOnTriggerEnterCallback(Action<Collider> triggerAction)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		public void SetBlock(bool value)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x31088A0", Offset = "0x3106EA0", VA = "0x1831088A0")]
		protected void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x31082E0", Offset = "0x31068E0", VA = "0x1831082E0")]
		public void RegisterOnTriggerExitCallback(Action<Collider> triggerAction)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x3108450", Offset = "0x3106A50", VA = "0x183108450")]
		public void UnregisterOnTriggerExitCallback(Action<Collider> triggerAction)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x3108910", Offset = "0x3106F10", VA = "0x183108910")]
		protected void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x31085C0", Offset = "0x3106BC0", VA = "0x1831085C0")]
		public void RegisterOnTriggerStayCallback(Action<Collider> triggerAction)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x3108730", Offset = "0x3106D30", VA = "0x183108730")]
		public void UnregisterOnTriggerStayCallback(Action<Collider> triggerAction)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x3108980", Offset = "0x3106F80", VA = "0x183108980")]
		protected void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x31089F0", Offset = "0x3106FF0", VA = "0x1831089F0")]
		public List<Collider> GetColliders()
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TriggerProxy()
		{
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _block;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _tagFilter;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x30")]
		private List<Collider> _cachedColliders;
	}
}
