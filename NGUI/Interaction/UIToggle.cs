using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/Toggle")]
	public class UIToggle : UIWidgetContainer
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		public bool value
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x26DF480", Offset = "0x26DDA80", VA = "0x1826DF480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x26DF490", Offset = "0x26DDA90", VA = "0x1826DF490")]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x17000181")]
		public bool isColliderEnabled
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x26DF4C0", Offset = "0x26DDAC0", VA = "0x1826DF4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00004A58 File Offset: 0x00002C58
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		[Obsolete("Use 'value' instead")]
		public bool isChecked
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x26DF480", Offset = "0x26DDA80", VA = "0x1826DF480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x26DF490", Offset = "0x26DDA90", VA = "0x1826DF490")]
			set
			{
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x26DF6E0", Offset = "0x26DDCE0", VA = "0x1826DF6E0")]
		public static UIToggle GetActiveToggle(int group)
		{
			return null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x26DF880", Offset = "0x26DDE80", VA = "0x1826DF880")]
		private void OnEnable()
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x26DF900", Offset = "0x26DDF00", VA = "0x1826DF900")]
		private void OnDisable()
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x26DF980", Offset = "0x26DDF80", VA = "0x1826DF980")]
		private void Start()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x26DFEE0", Offset = "0x26DE4E0", VA = "0x1826DFEE0")]
		private void OnClick()
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x26DFFD0", Offset = "0x26DE5D0", VA = "0x1826DFFD0")]
		public void Set(bool state)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x26E0A20", Offset = "0x26DF020", VA = "0x1826E0A20")]
		public UIToggle()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x0")]
		public static BetterList<UIToggle> list;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x8")]
		public static UIToggle current;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x20")]
		public int group;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget activeSprite;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x30")]
		public Animation activeAnimation;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x38")]
		public Animator animator;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x40")]
		public bool startsActive;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x41")]
		public bool instantTween;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x42")]
		public bool optionCanBeNone;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x48")]
		public List<EventDelegate> onChange;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x50")]
		public UIToggle.Validate validator;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private UISprite checkSprite;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private Animation checkAnimation;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private GameObject eventReceiver;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		[SerializeField]
		private string functionName;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private bool startsChecked;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x79")]
		private bool mIsActive;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x7A")]
		private bool mStarted;

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x060007D1 RID: 2001
		[Token(Token = "0x20000E0")]
		public delegate bool Validate(bool choice);
	}
}
