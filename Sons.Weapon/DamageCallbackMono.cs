using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public abstract class DamageCallbackMono : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		private event Action<IImpactSender, IImpactData> _impactReceivers
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x3199C70", Offset = "0x3198270", VA = "0x183199C70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x3199DE0", Offset = "0x31983E0", VA = "0x183199DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		private event Action<IBreakSender, IImpactData> _breakReceivers
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x3199F50", Offset = "0x3198550", VA = "0x183199F50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x319A0C0", Offset = "0x31986C0", VA = "0x18319A0C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		private event Action<DamageNode, IImpactData> _blockReceivers
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x319A230", Offset = "0x3198830", VA = "0x18319A230")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x319A3A0", Offset = "0x31989A0", VA = "0x18319A3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x319A510", Offset = "0x3198B10", VA = "0x18319A510")]
		public void RegisterImpactCallback(Action<IImpactSender, IImpactData> receiver)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x319A690", Offset = "0x3198C90", VA = "0x18319A690")]
		public void UnregisterImpactCallback(Action<IImpactSender, IImpactData> receiver)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x319A810", Offset = "0x3198E10", VA = "0x18319A810")]
		protected bool IsValid(IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		protected virtual bool IsValidImpact(IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x30CE6F0", Offset = "0x30CCCF0", VA = "0x1830CE6F0")]
		internal void OnBreak(IBreakSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x319A850", Offset = "0x3198E50", VA = "0x18319A850")]
		internal void OnBlockedAttack(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x319A870", Offset = "0x3198E70", VA = "0x18319A870")]
		internal void SendImpactCallback(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x319A0C0", Offset = "0x31986C0", VA = "0x18319A0C0")]
		public void UnregisterBreakCallback(Action<IBreakSender, IImpactData> onBreak)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x3199F50", Offset = "0x3198550", VA = "0x183199F50")]
		public void RegisterBreakCallback(Action<IBreakSender, IImpactData> onBreak)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x319A3A0", Offset = "0x31989A0", VA = "0x18319A3A0")]
		public void UnregisterBlockCallback(Action<DamageNode, IImpactData> onBlock)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x319A230", Offset = "0x3198830", VA = "0x18319A230")]
		public void RegisterBlockCallback(Action<DamageNode, IImpactData> onBlock)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void RegisterImpactValidateCallback(Func<IImpactData, bool> callback)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x319A890", Offset = "0x3198E90", VA = "0x18319A890")]
		public void UnregisterImpactValidateCallback(Func<IImpactData, bool> callback)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected DamageCallbackMono()
		{
		}

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x38")]
		private Func<IImpactData, bool> _impactValidateOverrideCallback;
	}
}
