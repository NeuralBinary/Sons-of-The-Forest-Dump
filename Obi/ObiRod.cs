using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	[AddComponentMenu("Physics/Obi/Obi Rod", 881)]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class ObiRod : ObiRopeBase, IStretchShearConstraintsUser, IBendTwistConstraintsUser, IChainConstraintsUser
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00004E14 File Offset: 0x00003014
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700015E")]
		public bool selfCollisions
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x2739840", Offset = "0x2737E40", VA = "0x182739840")]
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00004E2C File Offset: 0x0000302C
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700015F")]
		public bool stretchShearConstraintsEnabled
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x22711D0", Offset = "0x226F7D0", VA = "0x1822711D0", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x2805EC0", Offset = "0x28044C0", VA = "0x182805EC0", Slot = "39")]
			set
			{
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00004E44 File Offset: 0x00003044
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000160")]
		public float stretchCompliance
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0", Slot = "40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x2805EF0", Offset = "0x28044F0", VA = "0x182805EF0", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00004E5C File Offset: 0x0000305C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000161")]
		public float shear1Compliance
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270", Slot = "42")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x2805F10", Offset = "0x2804510", VA = "0x182805F10", Slot = "43")]
			set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00004E74 File Offset: 0x00003074
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000162")]
		public float shear2Compliance
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x2739A50", Offset = "0x2738050", VA = "0x182739A50", Slot = "44")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x2805F30", Offset = "0x2804530", VA = "0x182805F30", Slot = "45")]
			set
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000163")]
		public bool bendTwistConstraintsEnabled
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x61BF20", Offset = "0x61A520", VA = "0x18061BF20", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x2805F50", Offset = "0x2804550", VA = "0x182805F50", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00004EA4 File Offset: 0x000030A4
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000164")]
		public float torsionCompliance
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x2805F70", Offset = "0x2804570", VA = "0x182805F70", Slot = "48")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x2805F80", Offset = "0x2804580", VA = "0x182805F80", Slot = "49")]
			set
			{
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00004EBC File Offset: 0x000030BC
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000165")]
		public float bend1Compliance
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x13429E0", Offset = "0x1340FE0", VA = "0x1813429E0", Slot = "50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x2805FA0", Offset = "0x28045A0", VA = "0x182805FA0", Slot = "51")]
			set
			{
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00004ED4 File Offset: 0x000030D4
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000166")]
		public float bend2Compliance
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x2805FC0", Offset = "0x28045C0", VA = "0x182805FC0", Slot = "52")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x2805FD0", Offset = "0x28045D0", VA = "0x182805FD0", Slot = "53")]
			set
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000167")]
		public float plasticYield
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x1342A00", Offset = "0x1341000", VA = "0x181342A00", Slot = "54")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x2805FF0", Offset = "0x28045F0", VA = "0x182805FF0", Slot = "55")]
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00004F04 File Offset: 0x00003104
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000168")]
		public float plasticCreep
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1342A20", Offset = "0x1341020", VA = "0x181342A20", Slot = "56")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x2806010", Offset = "0x2804610", VA = "0x182806010", Slot = "57")]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00004F1C File Offset: 0x0000311C
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000169")]
		public bool chainConstraintsEnabled
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0xA03DE0", Offset = "0xA023E0", VA = "0x180A03DE0", Slot = "58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x2806030", Offset = "0x2804630", VA = "0x182806030", Slot = "59")]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700016A")]
		public float tightness
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x2806050", Offset = "0x2804650", VA = "0x182806050", Slot = "60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x2806060", Offset = "0x2804660", VA = "0x182806060", Slot = "61")]
			set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x1700016B")]
		public float interParticleDistance
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x2806080", Offset = "0x2804680", VA = "0x182806080")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700016C")]
		public override ObiActorBlueprint sourceBlueprint
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700016D")]
		public ObiRodBlueprint rodBlueprint
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x28060B0", Offset = "0x28046B0", VA = "0x1828060B0")]
			set
			{
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x2806280", Offset = "0x2804880", VA = "0x182806280", Slot = "20")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x2806290", Offset = "0x2804890", VA = "0x182806290", Slot = "28")]
		public override void LoadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x28062E0", Offset = "0x28048E0", VA = "0x1828062E0")]
		private void SetupRuntimeConstraints()
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x2806350", Offset = "0x2804950", VA = "0x182806350", Slot = "36")]
		protected override void RebuildElementsFromConstraintsInternal()
		{
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x28068C0", Offset = "0x2804EC0", VA = "0x1828068C0")]
		public ObiRod()
		{
		}

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected ObiRodBlueprint m_RodBlueprint;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected bool _stretchShearConstraintsEnabled;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		protected float _stretchCompliance;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected float _shear1Compliance;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		protected float _shear2Compliance;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected bool _bendTwistConstraintsEnabled;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		protected float _torsionCompliance;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected float _bend1Compliance;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		protected float _bend2Compliance;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0xE8")]
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float _plasticYield;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		protected float _plasticCreep;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected bool _chainConstraintsEnabled;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0xF4")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float _tightness;
	}
}
