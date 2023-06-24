using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[AddComponentMenu("Physics/Obi/Obi Cloth", 900)]
	[RequireComponent(typeof(MeshFilter))]
	public class ObiCloth : ObiClothBase, IVolumeConstraintsUser, ITetherConstraintsUser
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000002")]
		public override ObiActorBlueprint sourceBlueprint
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000003")]
		public override ObiClothBlueprintBase clothBlueprintBase
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000218C File Offset: 0x0000038C
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000004")]
		public bool volumeConstraintsEnabled
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0", Slot = "62")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x27394B0", Offset = "0x2737AB0", VA = "0x1827394B0", Slot = "63")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000021A4 File Offset: 0x000003A4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000005")]
		public float compressionCompliance
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x1342A20", Offset = "0x1341020", VA = "0x181342A20", Slot = "64")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x27394D0", Offset = "0x2737AD0", VA = "0x1827394D0", Slot = "65")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000021BC File Offset: 0x000003BC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000006")]
		public float pressure
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x1342C10", Offset = "0x1341210", VA = "0x181342C10", Slot = "66")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x27394F0", Offset = "0x2737AF0", VA = "0x1827394F0", Slot = "67")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000007")]
		public bool tetherConstraintsEnabled
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2739510", Offset = "0x2737B10", VA = "0x182739510", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2739520", Offset = "0x2737B20", VA = "0x182739520", Slot = "69")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000021EC File Offset: 0x000003EC
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000008")]
		public float tetherCompliance
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540", Slot = "70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2739550", Offset = "0x2737B50", VA = "0x182739550", Slot = "71")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002204 File Offset: 0x00000404
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000009")]
		public float tetherScale
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2739570", Offset = "0x2737B70", VA = "0x182739570", Slot = "72")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2739580", Offset = "0x2737B80", VA = "0x182739580", Slot = "73")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700000A")]
		public ObiClothBlueprint clothBlueprint
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x27395A0", Offset = "0x2737BA0", VA = "0x1827395A0")]
			set
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2739770", Offset = "0x2737D70", VA = "0x182739770", Slot = "20")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2739770", Offset = "0x2737D70", VA = "0x182739770")]
		private void SetupRuntimeConstraints()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x27397F0", Offset = "0x2737DF0", VA = "0x1827397F0")]
		public ObiCloth()
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected ObiClothBlueprint m_ClothBlueprint;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected bool _volumeConstraintsEnabled;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		protected float _compressionCompliance;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected float _pressure;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		protected bool _tetherConstraintsEnabled;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		protected float _tetherCompliance;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[Range(0.1f, 2f)]
		protected float _tetherScale;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		protected ObiClothRenderer m_renderer;
	}
}
