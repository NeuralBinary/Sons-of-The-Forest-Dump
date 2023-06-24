using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[AddComponentMenu("NGUI/Interaction/Key Navigation")]
	public class UIKeyNavigation : MonoBehaviour
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000151")]
		public static UIKeyNavigation current
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x26C1670", Offset = "0x26BFC70", VA = "0x1826C1670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x17000152")]
		public bool isColliderEnabled
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x26C1770", Offset = "0x26BFD70", VA = "0x1826C1770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x26C1AF0", Offset = "0x26C00F0", VA = "0x1826C1AF0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x26C1C20", Offset = "0x26C0220", VA = "0x1826C1C20")]
		private void Start()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x26C1CD0", Offset = "0x26C02D0", VA = "0x1826C1CD0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x26C1D50", Offset = "0x26C0350", VA = "0x1826C1D50")]
		private static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x26C2040", Offset = "0x26C0640", VA = "0x1826C2040")]
		private static bool CanSkipToNext(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x26C21B0", Offset = "0x26C07B0", VA = "0x1826C21B0")]
		public GameObject GetLeft()
		{
			return null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x26C2310", Offset = "0x26C0910", VA = "0x1826C2310")]
		public GameObject GetRight()
		{
			return null;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x26C2470", Offset = "0x26C0A70", VA = "0x1826C2470")]
		public GameObject GetUp()
		{
			return null;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x26C25D0", Offset = "0x26C0BD0", VA = "0x1826C25D0")]
		public GameObject GetDown()
		{
			return null;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x26C2730", Offset = "0x26C0D30", VA = "0x1826C2730")]
		public GameObject Get(Vector3 myDir, float x = 1f, float y = 1f)
		{
			return null;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x26C2E20", Offset = "0x26C1420", VA = "0x1826C2E20")]
		protected static Vector3 GetCenter(GameObject go)
		{
			return default(Vector3);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x26C3400", Offset = "0x26C1A00", VA = "0x1826C3400", Slot = "6")]
		public virtual void OnNavigate(KeyCode key)
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x26C3550", Offset = "0x26C1B50", VA = "0x1826C3550", Slot = "7")]
		public virtual void OnKey(KeyCode key)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x26C3AF0", Offset = "0x26C20F0", VA = "0x1826C3AF0", Slot = "8")]
		protected virtual void OnClick()
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIKeyNavigation()
		{
		}

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x0")]
		public static BetterList<UIKeyNavigation> list;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x20")]
		public bool CanNavigateToWhenDisabled;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x21")]
		public bool SkipToNextWhenDisabled;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x24")]
		public UIKeyNavigation.Constraint constraint;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject onUp;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject onDown;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject onLeft;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject onRight;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject onClick;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject onTab;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x58")]
		public bool startsSelected;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x59")]
		[NonSerialized]
		private bool mStarted;

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		public enum Constraint
		{
			// Token: 0x040004EF RID: 1263
			[Token(Token = "0x40004EF")]
			None,
			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40004F0")]
			Vertical,
			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			Horizontal,
			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40004F2")]
			Explicit
		}
	}
}
