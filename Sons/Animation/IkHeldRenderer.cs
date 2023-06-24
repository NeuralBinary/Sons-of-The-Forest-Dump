using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000905 RID: 2309
	[Token(Token = "0x2000905")]
	public class IkHeldRenderer : MonoBehaviour, IIkHeldRenderer, IMonoBehaviour
	{
		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x1700085F")]
		public IkLimbs Limb
		{
			[Token(Token = "0x600425E")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "4")]
			get
			{
				return IkLimbs.RightHand;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x00014268 File Offset: 0x00012468
		// (set) Token: 0x06004260 RID: 16992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000860")]
		public Vector3 InitialLocalPosition
		{
			[Token(Token = "0x600425F")]
			[Address(RVA = "0x781540", Offset = "0x77FB40", VA = "0x180781540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004260")]
			[Address(RVA = "0x781560", Offset = "0x77FB60", VA = "0x180781560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x00014280 File Offset: 0x00012480
		// (set) Token: 0x06004262 RID: 16994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000861")]
		public Quaternion InitialLocalRotation
		{
			[Token(Token = "0x6004261")]
			[Address(RVA = "0x151E610", Offset = "0x151CC10", VA = "0x18151E610", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6004262")]
			[Address(RVA = "0x151E620", Offset = "0x151CC20", VA = "0x18151E620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x00014298 File Offset: 0x00012498
		// (set) Token: 0x06004264 RID: 16996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000862")]
		public Vector3 InitialLocalScale
		{
			[Token(Token = "0x6004263")]
			[Address(RVA = "0x620480", Offset = "0x61EA80", VA = "0x180620480", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004264")]
			[Address(RVA = "0x6204A0", Offset = "0x61EAA0", VA = "0x1806204A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004265")]
		[Address(RVA = "0x3634C20", Offset = "0x3633220", VA = "0x183634C20")]
		private void Awake()
		{
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004266")]
		[Address(RVA = "0x3634CF0", Offset = "0x36332F0", VA = "0x183634CF0")]
		private void Start()
		{
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004267")]
		[Address(RVA = "0x3634D00", Offset = "0x3633300", VA = "0x183634D00")]
		private void OnEnable()
		{
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004268")]
		[Address(RVA = "0x3634E80", Offset = "0x3633480", VA = "0x183634E80")]
		private void OnDisable()
		{
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004269")]
		[Address(RVA = "0x36351F0", Offset = "0x36337F0", VA = "0x1836351F0")]
		private void Init()
		{
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public IkHeldRenderer()
		{
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426B")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "8")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426C")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "9")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x600426D")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040045C4 RID: 17860
		[Token(Token = "0x40045C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private IkLimbs _limb;

		// Token: 0x040045C5 RID: 17861
		[Token(Token = "0x40045C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IkTargetsController _controller;

		// Token: 0x040045C6 RID: 17862
		[Token(Token = "0x40045C6")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInitialized;
	}
}
