using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007F2 RID: 2034
	[Token(Token = "0x20007F2")]
	[AddComponentMenu("Sons/Characters/Instance Variation")]
	public class InstanceVariation : MonoBehaviour, IActorSeed, ISerializationCallbackReceiver
	{
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x170006ED")]
		private bool IsBase
		{
			[Token(Token = "0x60035BB")]
			[Address(RVA = "0x2E93BB0", Offset = "0x2E92BB0", VA = "0x182E93BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EE")]
		public VariationSet Variations
		{
			[Token(Token = "0x60035BC")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x2E933E0", Offset = "0x2E923E0", VA = "0x182E933E0")]
		public void OnEnable()
		{
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x2E93360", Offset = "0x2E92360", VA = "0x182E93360")]
		private void OnDisable()
		{
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x2E93460", Offset = "0x2E92460", VA = "0x182E93460")]
		private void OnValidate()
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x2E92F20", Offset = "0x2E91F20", VA = "0x182E92F20", Slot = "4")]
		public void ApplySeed(int seed, int subSet = 0)
		{
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x2E939A0", Offset = "0x2E929A0", VA = "0x182E939A0")]
		public void SetSeed(int seed)
		{
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x2E933D0", Offset = "0x2E923D0", VA = "0x182E933D0", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x2E93370", Offset = "0x2E92370", VA = "0x182E93370")]
		public bool IsItsParent(InstanceVariation instanceVariation)
		{
			return default(bool);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x2E93790", Offset = "0x2E92790", VA = "0x182E93790")]
		private void RegisterChild(InstanceVariation instanceVariation)
		{
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x2E939B0", Offset = "0x2E929B0", VA = "0x182E939B0")]
		public void ShowAll()
		{
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x2E93360", Offset = "0x2E92360", VA = "0x182E93360")]
		public void HideAll()
		{
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x2E939C0", Offset = "0x2E929C0", VA = "0x182E939C0")]
		private void ShowAll(bool value)
		{
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x2E92EF0", Offset = "0x2E91EF0", VA = "0x182E92EF0")]
		private void ApplyNow()
		{
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x2E93970", Offset = "0x2E92970", VA = "0x182E93970")]
		public void Reseed()
		{
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x2E93930", Offset = "0x2E92930", VA = "0x182E93930")]
		public void ReseedAndApply()
		{
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CC")]
		[Address(RVA = "0x2E92EF0", Offset = "0x2E91EF0", VA = "0x182E92EF0")]
		public void Apply()
		{
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CD")]
		[Address(RVA = "0x2E93230", Offset = "0x2E92230", VA = "0x182E93230")]
		public void Apply(int seed, VariationSet.Subset subset)
		{
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CE")]
		[Address(RVA = "0x2E92F40", Offset = "0x2E91F40", VA = "0x182E92F40")]
		private void Apply(Random ran, VariationSet.Subset subset)
		{
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x2E93660", Offset = "0x2E92660", VA = "0x182E93660")]
		private void PostApply()
		{
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x2E932B0", Offset = "0x2E922B0", VA = "0x182E932B0")]
		public int GetSeed()
		{
			return default(int);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x2E93B30", Offset = "0x2E92B30", VA = "0x182E93B30")]
		public InstanceVariation()
		{
		}

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InstanceVariation _baseVariation;

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Force match parent subset.. ie. if Clothed is picked in parent, this will be Clothed type.")]
		private bool _matchParentSubset;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<InstanceVariation> _children;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _forceReseed;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _randomSeed;

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VariationSet _variations;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VariationSet.Subset _subset;
	}
}
