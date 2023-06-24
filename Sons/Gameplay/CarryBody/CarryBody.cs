using System;
using System.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Sons.Ai.Vail;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.CarryBody
{
	// Token: 0x02000881 RID: 2177
	[Token(Token = "0x2000881")]
	public class CarryBody : MonoBehaviour
	{
		// Token: 0x06003E23 RID: 15907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
		public void IsCarryingBody(bool value)
		{
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x6003E24")]
		[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
		public bool IsCarryingBody()
		{
			return default(bool);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x6003E25")]
		[Address(RVA = "0x35CCC10", Offset = "0x35CB210", VA = "0x1835CCC10")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x35CCD70", Offset = "0x35CB370", VA = "0x1835CCD70")]
		private void OnValidate()
		{
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x35CD0F0", Offset = "0x35CB6F0", VA = "0x1835CD0F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x35CD1A0", Offset = "0x35CB7A0", VA = "0x1835CD1A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x35CD4E0", Offset = "0x35CBAE0", VA = "0x1835CD4E0")]
		public void PickupBody(GameObject parentObject)
		{
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x35CD640", Offset = "0x35CBC40", VA = "0x1835CD640")]
		public void ForceDrop()
		{
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x35CD650", Offset = "0x35CBC50", VA = "0x1835CD650")]
		private IEnumerator StartPickupBodyLocal(GameObject parentObject)
		{
			return null;
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x35CD750", Offset = "0x35CBD50", VA = "0x1835CD750")]
		private void ServerSendPickupBodyEvent(VailActor deadBodyActor)
		{
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x35CDAD0", Offset = "0x35CC0D0", VA = "0x1835CDAD0")]
		private void ClientSendPickupBodyEvent(VailActor bodyActor)
		{
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x35CDB90", Offset = "0x35CC190", VA = "0x1835CDB90")]
		public void OnPickupBodyEvent(PickupBodyEvent evt)
		{
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x35CE0B0", Offset = "0x35CC6B0", VA = "0x1835CE0B0")]
		private void HideDeadActor(VailActor deadBody)
		{
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x35CE2D0", Offset = "0x35CC8D0", VA = "0x1835CE2D0")]
		private void ShowHeldBody(VailActor actor)
		{
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x35CE370", Offset = "0x35CC970", VA = "0x1835CE370")]
		private void ShowHeldBody(VailActorTypeId typeId, int actorSeed, int variationSubset, int dismemberMask, int bloodMask)
		{
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x35CE660", Offset = "0x35CCC60", VA = "0x1835CE660")]
		private void HideHeldBody()
		{
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ClientReceivedBodyPickupEvent()
		{
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x35CE7C0", Offset = "0x35CCDC0", VA = "0x1835CE7C0")]
		private IEnumerator DoPickupBodyLocal(GameObject parentObject)
		{
			return null;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x35CE8C0", Offset = "0x35CCEC0", VA = "0x1835CE8C0")]
		private void CancelledPickupBody()
		{
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x35CE980", Offset = "0x35CCF80", VA = "0x1835CE980")]
		private void DropBodyLocal(bool instant)
		{
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E37")]
		[Address(RVA = "0x35CEA40", Offset = "0x35CD040", VA = "0x1835CEA40")]
		[UsedImplicitly]
		public void ReleaseBodyForDrop()
		{
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x35CEA50", Offset = "0x35CD050", VA = "0x1835CEA50")]
		private IEnumerator DoDropBodyLocal(bool instant)
		{
			return null;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E39")]
		[Address(RVA = "0x35CEB10", Offset = "0x35CD110", VA = "0x1835CEB10")]
		private void SendDropBodyEvent(Vector3 position, Quaternion rotation, Vector3 addVel)
		{
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0x35CEDD0", Offset = "0x35CD3D0", VA = "0x1835CEDD0")]
		public void OnDropBodyEvent(DropBodyEvent evt)
		{
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0x35CF0D0", Offset = "0x35CD6D0", VA = "0x1835CF0D0")]
		private void ApplyThrowPoseAndVelocity(VailActor deadBody, Vector3 position, Quaternion rotation, Vector3 addVel)
		{
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3C")]
		[Address(RVA = "0x35CF700", Offset = "0x35CDD00", VA = "0x1835CF700")]
		private void DropBodyServerOrOffline(Vector3 position, Quaternion rotation, Vector3 addVel)
		{
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x35CF9B0", Offset = "0x35CDFB0", VA = "0x1835CF9B0")]
		public CarryBody()
		{
		}

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		private const string BodyInteractDropUiId = "bodyInteract.drop";

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _dropSpeedAdd;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _dropVerticalSpeed;

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _dropRelativeForce;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _dropTorque;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BodyCarryDefinition[] _bodyDefinitions;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x48")]
		private BodyCarryDefinition _heldBody;

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x50")]
		private VailActor _deadBodyActor;

		// Token: 0x04003452 RID: 13394
		[Token(Token = "0x4003452")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _bodyHipsPath;

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _attachTransform;

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_rootTransform")]
		private Transform _playerRootTransform;

		// Token: 0x04003455 RID: 13397
		[Token(Token = "0x4003455")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x04003456 RID: 13398
		[Token(Token = "0x4003456")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PlayerInventory _playerInventory;

		// Token: 0x04003457 RID: 13399
		[Token(Token = "0x4003457")]
		[FieldOffset(Offset = "0x80")]
		private bool _isCarryingBody;

		// Token: 0x04003458 RID: 13400
		[Token(Token = "0x4003458")]
		[FieldOffset(Offset = "0x88")]
		private Transform _transform;

		// Token: 0x04003459 RID: 13401
		[Token(Token = "0x4003459")]
		[FieldOffset(Offset = "0x90")]
		private bool _cancelledPickupBody;

		// Token: 0x0400345A RID: 13402
		[Token(Token = "0x400345A")]
		[FieldOffset(Offset = "0x91")]
		private bool _releasedBodyForDrop;
	}
}
