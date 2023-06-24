using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Animation.PlayerControl;
using Sons.Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	public class GenericInteraction : MonoBehaviour
	{
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600337D RID: 13181 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600337E RID: 13182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000028")]
		private event Action _actionPerformed
		{
			[Token(Token = "0x600337D")]
			[Address(RVA = "0x34BAD30", Offset = "0x34B9330", VA = "0x1834BAD30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600337E")]
			[Address(RVA = "0x34BAE20", Offset = "0x34B9420", VA = "0x1834BAE20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600337F RID: 13183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000693")]
		private List<string> GetActionsMenuDropdown
		{
			[Token(Token = "0x600337F")]
			[Address(RVA = "0x34BAF10", Offset = "0x34B9510", VA = "0x1834BAF10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[Token(Token = "0x17000694")]
		public bool InteractionBlocked
		{
			[Token(Token = "0x6003380")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06003381 RID: 13185 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x17000695")]
		public bool InteractionFocused
		{
			[Token(Token = "0x6003381")]
			[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x34BAF50", Offset = "0x34B9550", VA = "0x1834BAF50")]
		private bool BlockedFullBodyInteraction()
		{
			return default(bool);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x34BAD30", Offset = "0x34B9330", VA = "0x1834BAD30")]
		public void RegisterActionPerformed(Action handler)
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x34BAE20", Offset = "0x34B9420", VA = "0x1834BAE20")]
		public void UnregisterActionPerformed(Action handler)
		{
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x17000696")]
		private bool ShowPlayerNetworkInteractionIdError
		{
			[Token(Token = "0x6003385")]
			[Address(RVA = "0x34BAF60", Offset = "0x34B9560", VA = "0x1834BAF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x34BAF80", Offset = "0x34B9580", VA = "0x1834BAF80")]
		private void OnValidate()
		{
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003387")]
		[Address(RVA = "0x34BB1A0", Offset = "0x34B97A0", VA = "0x1834BB1A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x6003388")]
		[Address(RVA = "0x34BB1E0", Offset = "0x34B97E0", VA = "0x1834BB1E0")]
		private bool ShouldShowGui()
		{
			return default(bool);
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x6003389")]
		[Address(RVA = "0x34BB270", Offset = "0x34B9870", VA = "0x1834BB270")]
		private bool PassesAlignmentThreshold()
		{
			return default(bool);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338A")]
		[Address(RVA = "0x34BB480", Offset = "0x34B9A80", VA = "0x1834BB480")]
		private void Update()
		{
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338B")]
		[Address(RVA = "0x34BB540", Offset = "0x34B9B40", VA = "0x1834BB540")]
		private static void ShowNetworkInteractionNotification(bool show, int waiting = 0, int playerCount = 0)
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338C")]
		[Address(RVA = "0x34BB6A0", Offset = "0x34B9CA0", VA = "0x1834BB6A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338D")]
		[Address(RVA = "0x34BB950", Offset = "0x34B9F50", VA = "0x1834BB950")]
		private void VerifyPlayerNetworkInteraction()
		{
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338E")]
		[Address(RVA = "0x34BBAD0", Offset = "0x34BA0D0", VA = "0x1834BBAD0")]
		private void VerifyDedicatedServerConnection()
		{
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x0000F738 File Offset: 0x0000D938
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x34BBBB0", Offset = "0x34BA1B0", VA = "0x1834BBBB0")]
		private bool TryFindNetworkInteraction()
		{
			return default(bool);
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x34BBC10", Offset = "0x34BA210", VA = "0x1834BBC10")]
		private void CheckInputAction()
		{
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003391")]
		[Address(RVA = "0x34BBF70", Offset = "0x34BA570", VA = "0x1834BBF70")]
		private void ConnectToPlayerNetworkInteraction()
		{
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x34BC550", Offset = "0x34BAB50", VA = "0x1834BC550")]
		private void DisconnectFromPlayerNetworkInteraction()
		{
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x34BC830", Offset = "0x34BAE30", VA = "0x1834BC830")]
		private void PlayerNetworkInteractionRemoveCallback(int index)
		{
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x34BC8D0", Offset = "0x34BAED0", VA = "0x1834BC8D0")]
		public void PlayerNetworkInteractionAddCallback(int index)
		{
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x34BC970", Offset = "0x34BAF70", VA = "0x1834BC970")]
		public void PlayerNetworkInteractionPerformedCallback()
		{
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x34BC9C0", Offset = "0x34BAFC0", VA = "0x1834BC9C0")]
		private void SetInteractGuiShow(bool interactionShow)
		{
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x0000F750 File Offset: 0x0000D950
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x34BCC30", Offset = "0x34BB230", VA = "0x1834BCC30")]
		private bool PassesAlignmentThresholdForGui()
		{
			return default(bool);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x34BCC50", Offset = "0x34BB250", VA = "0x1834BCC50", Slot = "4")]
		public virtual void GrabEnter()
		{
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x34BCD20", Offset = "0x34BB320", VA = "0x1834BCD20")]
		private void UpdateAlignmentPass()
		{
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x34BCD40", Offset = "0x34BB340", VA = "0x1834BCD40", Slot = "5")]
		public virtual void GrabExit()
		{
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x34BCD60", Offset = "0x34BB360", VA = "0x1834BCD60")]
		public void SetInteractionBlocked(bool value)
		{
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x34BCDA0", Offset = "0x34BB3A0", VA = "0x1834BCDA0")]
		public GenericInteraction()
		{
		}

		// Token: 0x04002C9C RID: 11420
		[Token(Token = "0x4002C9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _idleGui;

		// Token: 0x04002C9D RID: 11421
		[Token(Token = "0x4002C9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _interactGui;

		// Token: 0x04002C9E RID: 11422
		[Token(Token = "0x4002C9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _actionPerformedUnityEvent;

		// Token: 0x04002C9F RID: 11423
		[Token(Token = "0x4002C9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _usePlayerNetworkInteraction;

		// Token: 0x04002CA0 RID: 11424
		[Token(Token = "0x4002CA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerNetworkInteraction _playerNetworkInteraction;

		// Token: 0x04002CA1 RID: 11425
		[Token(Token = "0x4002CA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _playerNetworkInteractionId;

		// Token: 0x04002CA2 RID: 11426
		[Token(Token = "0x4002CA2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _useAlignmentThreshold;

		// Token: 0x04002CA3 RID: 11427
		[Token(Token = "0x4002CA3")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _useAlignmentThresholdForGui;

		// Token: 0x04002CA4 RID: 11428
		[Token(Token = "0x4002CA4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _alignmentThreshold;

		// Token: 0x04002CA5 RID: 11429
		[Token(Token = "0x4002CA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _needsFullBodyInteraction;

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x59")]
		private bool _grabberFocused;

		// Token: 0x04002CA7 RID: 11431
		[Token(Token = "0x4002CA7")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_buttonId")]
		[SerializeField]
		private string _actionId;

		// Token: 0x04002CA8 RID: 11432
		[Token(Token = "0x4002CA8")]
		[FieldOffset(Offset = "0x68")]
		private float _currentAlignment;

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0x70")]
		private string _cachedActionString;

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x78")]
		private InputSystem.Action _cachedAction;

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x88")]
		private bool _interactionBlocked;

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x89")]
		private bool _passesAlignmentThreshold;

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x8A")]
		private bool _playerNetworkInteractionWaiting;

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x8B")]
		private bool _reportedPlayerNetworkInteractionIdError;
	}
}
