using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[Serializable]
	public class UiElement
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x301AEC0", Offset = "0x30194C0", VA = "0x18301AEC0")]
		private UiElement(UiElement uiElement)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public GameObject GetTarget()
		{
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		public UiElement.UiElementTransformType GetTransformType()
		{
			return UiElement.UiElementTransformType.Auto;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public Vector3 WorldPos
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x28D17F0", Offset = "0x28CFDF0", VA = "0x1828D17F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x301B050", Offset = "0x3019650", VA = "0x18301B050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000014")]
		public string Id
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public Quaternion WorldRotation
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x301B060", Offset = "0x3019660", VA = "0x18301B060")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x25AEE60", Offset = "0x25AD460", VA = "0x1825AEE60")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public bool AlwaysFaceCamera
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x301B1A0", Offset = "0x30197A0", VA = "0x18301B1A0")]
		public bool Matches(int id)
		{
			return default(bool);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x301B1B0", Offset = "0x30197B0", VA = "0x18301B1B0")]
		private void RefreshHash()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x301B200", Offset = "0x3019800", VA = "0x18301B200")]
		public static int GetHash(string id)
		{
			return 0;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x301B240", Offset = "0x3019840", VA = "0x18301B240")]
		public bool Matches(string id)
		{
			return default(bool);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x301B300", Offset = "0x3019900", VA = "0x18301B300")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x301B420", Offset = "0x3019A20", VA = "0x18301B420")]
		public UiElement RequestPooled()
		{
			return null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x301B710", Offset = "0x3019D10", VA = "0x18301B710")]
		private UiElement GetNewPooled()
		{
			return null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x301B8D0", Offset = "0x3019ED0", VA = "0x18301B8D0")]
		private void CreateTargetInstance()
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000017")]
		public bool IsActive
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x301BAF0", Offset = "0x301A0F0", VA = "0x18301BAF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x301BC10", Offset = "0x301A210", VA = "0x18301BC10")]
		public void ReturnPooled(GameObject uiGameObject)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x301BC40", Offset = "0x301A240", VA = "0x18301BC40")]
		internal UiElement FindPooledElement(GameObject uiGameObject)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x301B1B0", Offset = "0x30197B0", VA = "0x18301B1B0")]
		public void OnValidate()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0")]
		public void SetSnapWorldPos(bool snap)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
		public bool GetSnapWorldPos()
		{
			return default(bool);
		}

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _target;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _idHash;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UiElement.UiElementTransformType _transformType;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxPooled;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x30")]
		private List<UiElement> _pooledElements;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion _worldRotation;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x48")]
		private bool _snapWorldPos;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		public enum UiElementTransformType
		{
			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			Auto,
			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			ScreenSpace,
			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			WorldSpace
		}
	}
}
