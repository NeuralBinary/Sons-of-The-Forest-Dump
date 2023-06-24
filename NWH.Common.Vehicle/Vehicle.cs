using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace NWH
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(Rigidbody))]
	[DisallowMultipleComponent]
	public abstract class Vehicle : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public bool IsAwake
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x26FA7A0", Offset = "0x26F8DA0", VA = "0x1826FA7A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		public Vehicle.MultiplayerInstanceType VehicleMultiplayerInstanceType
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return Vehicle.MultiplayerInstanceType.Local;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public Vector3 LocalAcceleration
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x26FA7B0", Offset = "0x26F8DB0", VA = "0x1826FA7B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x26FA7D0", Offset = "0x26F8DD0", VA = "0x1826FA7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020B0 File Offset: 0x000002B0
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public float LocalForwardAcceleration
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x26FA7E0", Offset = "0x26F8DE0", VA = "0x1826FA7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public float LocalForwardVelocity
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x26FA7F0", Offset = "0x26F8DF0", VA = "0x1826FA7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020E0 File Offset: 0x000002E0
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public Vector3 LocalVelocity
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x26FA800", Offset = "0x26F8E00", VA = "0x1826FA800")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x26FA820", Offset = "0x26F8E20", VA = "0x1826FA820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x17000007")]
		public float Speed
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x26FA840", Offset = "0x26F8E40", VA = "0x1826FA840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x17000008")]
		public float SpeedSigned
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002128 File Offset: 0x00000328
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x26FA860", Offset = "0x26F8E60", VA = "0x1826FA860")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x26FA880", Offset = "0x26F8E80", VA = "0x1826FA880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002140 File Offset: 0x00000340
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public float VelocityMagnitude
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x26FA8A0", Offset = "0x26F8EA0", VA = "0x1826FA8A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26FA8B0", Offset = "0x26F8EB0", VA = "0x1826FA8B0", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26FAC30", Offset = "0x26F9230", VA = "0x1826FAC30", Slot = "5")]
		public virtual void FixedUpdate()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26FAEC0", Offset = "0x26F94C0", VA = "0x1826FAEC0", Slot = "6")]
		public virtual void Sleep()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x26FAEF0", Offset = "0x26F94F0", VA = "0x1826FAEF0", Slot = "7")]
		public virtual void Wake()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x26FAF20", Offset = "0x26F9520", VA = "0x1826FAF20", Slot = "8")]
		public virtual void SetMultiplayerInstanceType(Vehicle.MultiplayerInstanceType instanceType, bool isKinematic = true)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26FAF40", Offset = "0x26F9540", VA = "0x1826FAF40")]
		protected Vehicle()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("    Called when vehicle is put to sleep.")]
		public UnityEvent onSleep;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("    Called when vehicle is woken up.")]
		public UnityEvent onWake;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("    Cached value of vehicle rigidbody.")]
		public Rigidbody vehicleRigidbody;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("    Cached value of vehicle transform.")]
		public Transform vehicleTransform;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("    Should be true when camera is inside vehicle (cockpit, cabin, etc.).\r\n    Used for audio effects.")]
		public bool cameraInsideVehicle;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onSetMultiplayerInstanceType;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("    Determines if vehicle is running locally is synchronized over active multiplayer framework.")]
		protected Vehicle.MultiplayerInstanceType _multiplayerInstanceType;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected bool _isAwake;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _prevLocalVelocity;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		public enum MultiplayerInstanceType
		{
			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			Local,
			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			Remote
		}
	}
}
