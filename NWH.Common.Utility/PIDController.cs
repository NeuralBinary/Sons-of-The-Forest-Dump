using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.Common.Utility
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class PIDController
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x26F9F00", Offset = "0x26F8500", VA = "0x1826F9F00")]
		public PIDController(float gainProportional, float gainIntegral, float gainDerivative, float outputMin, float outputMax)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public float GainDerivative
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public float GainIntegral
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000242C File Offset: 0x0000062C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public float GainProportional
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public float IntegralTerm
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public float ProcessVariable
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x26F9F40", Offset = "0x26F8540", VA = "0x1826F9F40")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public float ProcessVariableLast
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		public float SetPoint
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x26F9F50", Offset = "0x26F8550", VA = "0x1826F9F50")]
		public float ControlVariable(float timeSinceLastUpdate)
		{
			return 0f;
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public float maxValue;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x14")]
		public float minValue;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		private float _processVariable;
	}
}
