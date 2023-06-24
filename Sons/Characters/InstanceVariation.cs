using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	[AddComponentMenu("Sons/Characters/Instance Variation")]
	public class InstanceVariation : MonoBehaviour, IActorSeed, ISerializationCallbackReceiver
	{
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x17000662")]
		private bool IsBase
		{
			[Token(Token = "0x6002F60")]
			[Address(RVA = "0x345EE90", Offset = "0x345D490", VA = "0x18345EE90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000663")]
		public VariationSet Variations
		{
			[Token(Token = "0x6002F61")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F62")]
		[Address(RVA = "0x345EF50", Offset = "0x345D550", VA = "0x18345EF50")]
		public void OnEnable()
		{
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F63")]
		[Address(RVA = "0x345EF90", Offset = "0x345D590", VA = "0x18345EF90")]
		private void OnDisable()
		{
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F64")]
		[Address(RVA = "0x345EFA0", Offset = "0x345D5A0", VA = "0x18345EFA0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x345F260", Offset = "0x345D860", VA = "0x18345F260", Slot = "4")]
		public void ApplySeed(int seed, int subSet = 0)
		{
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F66")]
		[Address(RVA = "0x345F280", Offset = "0x345D880", VA = "0x18345F280")]
		public void SetSeed(int seed)
		{
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F67")]
		[Address(RVA = "0x345F290", Offset = "0x345D890", VA = "0x18345F290", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F68")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x0000E298 File Offset: 0x0000C498
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x345F2A0", Offset = "0x345D8A0", VA = "0x18345F2A0")]
		public bool IsItsParent(InstanceVariation instanceVariation)
		{
			return default(bool);
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x345F3D0", Offset = "0x345D9D0", VA = "0x18345F3D0")]
		private void RegisterChild(InstanceVariation instanceVariation)
		{
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x345F610", Offset = "0x345DC10", VA = "0x18345F610")]
		public void ShowAll()
		{
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x345EF90", Offset = "0x345D590", VA = "0x18345EF90")]
		public void HideAll()
		{
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x345F620", Offset = "0x345DC20", VA = "0x18345F620")]
		private void ShowAll(bool value)
		{
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6E")]
		[Address(RVA = "0x345F820", Offset = "0x345DE20", VA = "0x18345F820")]
		private void ApplyNow()
		{
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6F")]
		[Address(RVA = "0x345F850", Offset = "0x345DE50", VA = "0x18345F850")]
		public void Reseed()
		{
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F70")]
		[Address(RVA = "0x345F8B0", Offset = "0x345DEB0", VA = "0x18345F8B0")]
		public void ReseedAndApply()
		{
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0x345F820", Offset = "0x345DE20", VA = "0x18345F820")]
		public void Apply()
		{
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F72")]
		[Address(RVA = "0x345F930", Offset = "0x345DF30", VA = "0x18345F930")]
		public void Apply(int seed, VariationSet.Subset subset)
		{
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x345F9B0", Offset = "0x345DFB0", VA = "0x18345F9B0")]
		private void Apply(System.Random ran, VariationSet.Subset subset)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x345FE90", Offset = "0x345E490", VA = "0x18345FE90")]
		private void PostApply()
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x3460020", Offset = "0x345E620", VA = "0x183460020")]
		public int GetSeed()
		{
			return 0;
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x34600B0", Offset = "0x345E6B0", VA = "0x1834600B0")]
		public InstanceVariation()
		{
		}

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InstanceVariation _baseVariation;

		// Token: 0x04002900 RID: 10496
		[Token(Token = "0x4002900")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Force match parent subset.. ie. if Clothed is picked in parent, this will be Clothed type.")]
		[SerializeField]
		private bool _matchParentSubset;

		// Token: 0x04002901 RID: 10497
		[Token(Token = "0x4002901")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<InstanceVariation> _children;

		// Token: 0x04002902 RID: 10498
		[Token(Token = "0x4002902")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _forceReseed;

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _randomSeed;

		// Token: 0x04002904 RID: 10500
		[Token(Token = "0x4002904")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VariationSet _variations;

		// Token: 0x04002905 RID: 10501
		[Token(Token = "0x4002905")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VariationSet.Subset _subset;
	}
}
