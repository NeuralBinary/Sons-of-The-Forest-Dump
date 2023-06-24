using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/NGUI Progress Bar")]
	public class UIProgressBar : UIWidgetContainer
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000167")]
		public Transform cachedTransform
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x26D19F0", Offset = "0x26CFFF0", VA = "0x1826D19F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000168")]
		public Camera cachedCamera
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x26D1B50", Offset = "0x26D0150", VA = "0x1826D1B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public UIWidget foregroundWidget
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x26D1D30", Offset = "0x26D0330", VA = "0x1826D1D30")]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		public UIWidget backgroundWidget
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x26D1EA0", Offset = "0x26D04A0", VA = "0x1826D1EA0")]
			set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00004800 File Offset: 0x00002A00
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		public UIProgressBar.FillDirection fillDirection
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			get
			{
				return UIProgressBar.FillDirection.LeftToRight;
			}
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x26D2010", Offset = "0x26D0610", VA = "0x1826D2010")]
			set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016C")]
		public float value
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x26D2030", Offset = "0x26D0630", VA = "0x1826D2030")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x26D2080", Offset = "0x26D0680", VA = "0x1826D2080")]
			set
			{
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00004830 File Offset: 0x00002A30
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public float alpha
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x26D2260", Offset = "0x26D0860", VA = "0x1826D2260")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x26D23F0", Offset = "0x26D09F0", VA = "0x1826D23F0")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x1700016E")]
		protected bool isHorizontal
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x26D2CC0", Offset = "0x26D12C0", VA = "0x1826D2CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x1700016F")]
		protected bool isInverted
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x26D2CE0", Offset = "0x26D12E0", VA = "0x1826D2CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x26D2CF0", Offset = "0x26D12F0", VA = "0x1826D2CF0")]
		protected void Start()
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		protected virtual void Upgrade()
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x26D2F90", Offset = "0x26D1590", VA = "0x1826D2F90")]
		protected void Update()
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x26D2FB0", Offset = "0x26D15B0", VA = "0x1826D2FB0")]
		protected void OnValidate()
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x26D30D0", Offset = "0x26D16D0", VA = "0x1826D30D0")]
		protected float ScreenToValue(Vector2 screenPos)
		{
			return 0f;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x26D3610", Offset = "0x26D1C10", VA = "0x1826D3610", Slot = "6")]
		protected virtual float LocalToValue(Vector2 localPos)
		{
			return 0f;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x26D37E0", Offset = "0x26D1DE0", VA = "0x1826D37E0", Slot = "7")]
		public virtual void ForceUpdate()
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x26D44D0", Offset = "0x26D2AD0", VA = "0x1826D44D0")]
		protected void SetThumbPosition(Vector3 worldPos)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x26D4980", Offset = "0x26D2F80", VA = "0x1826D4980", Slot = "8")]
		public virtual void OnPan(Vector2 delta)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x26D4A80", Offset = "0x26D3080", VA = "0x1826D4A80")]
		public UIProgressBar()
		{
		}

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x0")]
		public static UIProgressBar current;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x20")]
		public UIProgressBar.OnDragFinished onDragFinished;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x28")]
		public Transform thumb;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		protected UIWidget mBG;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		protected UIWidget mFG;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		protected float mValue;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x44")]
		[HideInInspector]
		[SerializeField]
		protected UIProgressBar.FillDirection mFill;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x48")]
		protected Transform mTrans;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x50")]
		protected bool mIsDirty;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x58")]
		protected Camera mCam;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x60")]
		protected float mOffset;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x64")]
		public int numberOfSteps;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x68")]
		public List<EventDelegate> onChange;

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		public enum FillDirection
		{
			// Token: 0x0400056E RID: 1390
			[Token(Token = "0x400056E")]
			LeftToRight,
			// Token: 0x0400056F RID: 1391
			[Token(Token = "0x400056F")]
			RightToLeft,
			// Token: 0x04000570 RID: 1392
			[Token(Token = "0x4000570")]
			BottomToTop,
			// Token: 0x04000571 RID: 1393
			[Token(Token = "0x4000571")]
			TopToBottom
		}

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000762 RID: 1890
		[Token(Token = "0x20000CD")]
		public delegate void OnDragFinished();
	}
}
