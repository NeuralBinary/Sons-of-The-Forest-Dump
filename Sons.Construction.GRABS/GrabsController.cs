using System;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class GrabsController : SingletonBehaviour<GrabsController>, IAimRayProvider, ITargetFaceProvider
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000027A4 File Offset: 0x000009A4
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000055")]
		public int ActiveBlueprintNum
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x8DCFD0", Offset = "0x8DB5D0", VA = "0x1808DCFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000056")]
		public Transform AimTransform
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x17000057")]
		public Ray AimRay
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2D94D80", Offset = "0x2D93380", VA = "0x182D94D80", Slot = "10")]
			get
			{
				return default(Ray);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000058")]
		public BlueprintFace TargetFace
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000059")]
		public IGrabsControllerInput Input
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x1700005A")]
		public float MaxPlaceDistance
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x1700005B")]
		public float RotationSpeed
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2D94EE0", Offset = "0x2D934E0", VA = "0x182D94EE0")]
		private void Start()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2D95170", Offset = "0x2D93770", VA = "0x182D95170")]
		private void OnDisable()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2D951A0", Offset = "0x2D937A0", VA = "0x182D951A0")]
		private void Update()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2D952E0", Offset = "0x2D938E0", VA = "0x182D952E0")]
		private void SetTargetFace(BlueprintFace face)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2D95510", Offset = "0x2D93B10", VA = "0x182D95510")]
		private void SetTargetInteractionPoint(InteractionPoint ip)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2D95840", Offset = "0x2D93E40", VA = "0x182D95840")]
		private void SetState(GrabsController.States state)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2D95940", Offset = "0x2D93F40", VA = "0x182D95940")]
		private void SetRunningOperation(Operation op)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2D95B10", Offset = "0x2D94110", VA = "0x182D95B10")]
		private void UpdateIdle()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2D95BE0", Offset = "0x2D941E0", VA = "0x182D95BE0")]
		private void UpdateTargeting()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2D95EB0", Offset = "0x2D944B0", VA = "0x182D95EB0")]
		private void UpdateOperation()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2D96060", Offset = "0x2D94660", VA = "0x182D96060")]
		private void InitiatePlaceNew()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2D960B0", Offset = "0x2D946B0", VA = "0x182D960B0")]
		private void InitiateCancelOperation(InteractionPoint targetInteractionPoint)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2D961F0", Offset = "0x2D947F0", VA = "0x182D961F0")]
		private void InitiateExtrudeOperation(InteractionPoint targetInteractionPoint)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2D96300", Offset = "0x2D94900", VA = "0x182D96300")]
		private void InitiateRepositionOperation(InteractionPoint targetInteractionPoint)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2D96410", Offset = "0x2D94A10", VA = "0x182D96410")]
		private void CancelOperation()
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2D96520", Offset = "0x2D94B20", VA = "0x182D96520")]
		private void ValidateOperation()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2D966C0", Offset = "0x2D94CC0", VA = "0x182D966C0")]
		private bool TryGetTargetedInteractionPoint(out InteractionPoint targetIP)
		{
			return default(bool);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2D968B0", Offset = "0x2D94EB0", VA = "0x182D968B0")]
		public static void Toggle(bool onOff)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2D96960", Offset = "0x2D94F60", VA = "0x182D96960")]
		public static void RegisterAim(Transform aimTransform)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2D96A00", Offset = "0x2D95000", VA = "0x182D96A00")]
		public static void UnregisterAim(Transform aimTransform)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void RegisterInput(IGrabsControllerInput grabsControllerInput)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2D96B50", Offset = "0x2D95150", VA = "0x182D96B50")]
		public void UnregisterInput(IGrabsControllerInput grabsControllerInput)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2D96BB0", Offset = "0x2D951B0", VA = "0x182D96BB0")]
		public GrabsController()
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OperationFactory _placeNewOperationFactory;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Settings")]
		private float _maxPlaceDistance;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxGrabDistance;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _rotationSpeed;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Header("Debug")]
		private bool _verboseStateChanges;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _verboseTargetFaceChanges;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x40")]
		private GrabsController.States _state;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x48")]
		private IFaceLookup _faceLookup;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x50")]
		private IInteractionPointLookup _ipLookup;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x58")]
		private bool _showingPreview;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x60")]
		private InteractionPoint _targetIP;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x68")]
		private Operation _operation;

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public enum States
		{
			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000090")]
			Idle,
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			Targeting,
			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000092")]
			RunningOperation
		}
	}
}
