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
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	public class CarryBody : MonoBehaviour
	{
		// Token: 0x06002FB9 RID: 12217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x2180920", Offset = "0x217F920", VA = "0x182180920")]
		public void IsCarryingBody(bool value)
		{
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0000DB48 File Offset: 0x0000BD48
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x20452A0", Offset = "0x20442A0", VA = "0x1820452A0")]
		public bool IsCarryingBody()
		{
			return default(bool);
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x2E22720", Offset = "0x2E21720", VA = "0x182E22720")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x2E22DC0", Offset = "0x2E21DC0", VA = "0x182E22DC0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x2E22B00", Offset = "0x2E21B00", VA = "0x182E22B00")]
		private void OnEnable()
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x2E227B0", Offset = "0x2E217B0", VA = "0x182E227B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x2E22F20", Offset = "0x2E21F20", VA = "0x182E22F20")]
		public void PickupBody(GameObject parentObject)
		{
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x2E22580", Offset = "0x2E21580", VA = "0x182E22580")]
		public void ForceDrop()
		{
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x2E23480", Offset = "0x2E22480", VA = "0x182E23480")]
		private IEnumerator StartPickupBodyLocal(GameObject parentObject)
		{
			return null;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x2E230C0", Offset = "0x2E220C0", VA = "0x182E230C0")]
		private void ServerSendPickupBodyEvent(VailActor deadBodyActor)
		{
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x2E221C0", Offset = "0x2E211C0", VA = "0x182E221C0")]
		private void ClientSendPickupBodyEvent(VailActor bodyActor)
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x2E22B30", Offset = "0x2E21B30", VA = "0x182E22B30")]
		public void OnPickupBodyEvent(PickupBodyEvent evt)
		{
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x2E22590", Offset = "0x2E21590", VA = "0x182E22590")]
		private void HideDeadActor(VailActor deadBody)
		{
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0x2E233E0", Offset = "0x2E223E0", VA = "0x182E233E0")]
		private void ShowHeldBody(VailActor actor)
		{
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x2E231E0", Offset = "0x2E221E0", VA = "0x182E231E0")]
		private void ShowHeldBody(VailActorTypeId typeId, int actorSeed, int variationSubset, int dismemberMask, int bloodMask)
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x2E22690", Offset = "0x2E21690", VA = "0x182E22690")]
		private void HideHeldBody()
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void ClientReceivedBodyPickupEvent()
		{
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0x2E22300", Offset = "0x2E21300", VA = "0x182E22300")]
		private IEnumerator DoPickupBodyLocal()
		{
			return null;
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0x2E22160", Offset = "0x2E21160", VA = "0x182E22160")]
		private void CancelledPickupBody()
		{
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x2E22370", Offset = "0x2E21370", VA = "0x182E22370")]
		private void DropBodyLocal(bool instant)
		{
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x2E22FB0", Offset = "0x2E21FB0", VA = "0x182E22FB0")]
		[UsedImplicitly]
		public void ReleaseBodyForDrop()
		{
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x2E22280", Offset = "0x2E21280", VA = "0x182E22280")]
		private IEnumerator DoDropBodyLocal(bool instant)
		{
			return null;
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x2E22FC0", Offset = "0x2E21FC0", VA = "0x182E22FC0")]
		private void SendDropBodyEvent(Vector3 position, Quaternion rotation, Vector3 addVel)
		{
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x2E22940", Offset = "0x2E21940", VA = "0x182E22940")]
		public void OnDropBodyEvent(DropBodyEvent evt)
		{
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x2E21DF0", Offset = "0x2E20DF0", VA = "0x182E21DF0")]
		private void ApplyThrowPoseAndVelocity(VailActor deadBody, Vector3 position, Quaternion rotation, Vector3 addVel)
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x2E22400", Offset = "0x2E21400", VA = "0x182E22400")]
		private void DropBodyServerOrOffline(Vector3 position, Quaternion rotation, Vector3 addVel)
		{
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x2E23510", Offset = "0x2E22510", VA = "0x182E23510")]
		public CarryBody()
		{
		}

		// Token: 0x04002A1F RID: 10783
		[Token(Token = "0x4002A1F")]
		private const string BodyInteractDropUiId = "bodyInteract.drop";

		// Token: 0x04002A20 RID: 10784
		[Token(Token = "0x4002A20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _dropSpeedAdd;

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _dropVerticalSpeed;

		// Token: 0x04002A22 RID: 10786
		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _dropRelativeForce;

		// Token: 0x04002A23 RID: 10787
		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _dropTorque;

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BodyCarryDefinition[] _bodyDefinitions;

		// Token: 0x04002A25 RID: 10789
		[Token(Token = "0x4002A25")]
		[FieldOffset(Offset = "0x48")]
		private BodyCarryDefinition _heldBody;

		// Token: 0x04002A26 RID: 10790
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x50")]
		private VailActor _deadBodyActor;

		// Token: 0x04002A27 RID: 10791
		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _bodyHipsPath;

		// Token: 0x04002A28 RID: 10792
		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _attachTransform;

		// Token: 0x04002A29 RID: 10793
		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_rootTransform")]
		private Transform _playerRootTransform;

		// Token: 0x04002A2A RID: 10794
		[Token(Token = "0x4002A2A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x04002A2B RID: 10795
		[Token(Token = "0x4002A2B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PlayerInventory _playerInventory;

		// Token: 0x04002A2C RID: 10796
		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x80")]
		private bool _isCarryingBody;

		// Token: 0x04002A2D RID: 10797
		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0x88")]
		private Transform _transform;

		// Token: 0x04002A2E RID: 10798
		[Token(Token = "0x4002A2E")]
		[FieldOffset(Offset = "0x90")]
		private bool _cancelledPickupBody;

		// Token: 0x04002A2F RID: 10799
		[Token(Token = "0x4002A2F")]
		[FieldOffset(Offset = "0x91")]
		private bool _releasedBodyForDrop;
	}
}
