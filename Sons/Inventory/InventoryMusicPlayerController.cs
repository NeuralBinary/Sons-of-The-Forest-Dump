using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005EF RID: 1519
	[Token(Token = "0x20005EF")]
	[AddComponentMenu("Sons/Inventory/InventoryMusicPlayerController")]
	public class InventoryMusicPlayerController : MonoBehaviour
	{
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x1700053C")]
		public bool IsPowerOn
		{
			[Token(Token = "0x6002788")]
			[Address(RVA = "0x33C8D70", Offset = "0x33C7370", VA = "0x1833C8D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x33C8D90", Offset = "0x33C7390", VA = "0x1833C8D90")]
		private void Start()
		{
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x33C8EE0", Offset = "0x33C74E0", VA = "0x1833C8EE0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x33C9310", Offset = "0x33C7910", VA = "0x1833C9310")]
		private void OnDisable()
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x33C96B0", Offset = "0x33C7CB0", VA = "0x1833C96B0")]
		private void TryInteractWithButtons(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278D")]
		[Address(RVA = "0x33C9860", Offset = "0x33C7E60", VA = "0x1833C9860")]
		private void TogglePower()
		{
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278E")]
		[Address(RVA = "0x33C98C0", Offset = "0x33C7EC0", VA = "0x1833C98C0")]
		private static void SetupButton(GameObject buttonObject, UnityAction onEnter, UnityAction onExit, ref MeshOutliner outMeshOutliner)
		{
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278F")]
		[Address(RVA = "0x33C9B70", Offset = "0x33C8170", VA = "0x1833C9B70")]
		private void OnSongSwitchEnter()
		{
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002790")]
		[Address(RVA = "0x33C9BE0", Offset = "0x33C81E0", VA = "0x1833C9BE0")]
		private void OnSongSwitchExit()
		{
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002791")]
		[Address(RVA = "0x33C9C50", Offset = "0x33C8250", VA = "0x1833C9C50")]
		private void OnPowerSwitchOnEnter()
		{
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002792")]
		[Address(RVA = "0x33C9CC0", Offset = "0x33C82C0", VA = "0x1833C9CC0")]
		private void OnPowerSwitchOnExit()
		{
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x33C9D30", Offset = "0x33C8330", VA = "0x1833C9D30")]
		private void OnSongChanged(EventInstance eventInstance)
		{
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002794")]
		[Address(RVA = "0x33C9D60", Offset = "0x33C8360", VA = "0x1833C9D60")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002795")]
		[Address(RVA = "0x33C9DC0", Offset = "0x33C83C0", VA = "0x1833C9DC0")]
		public void TurnOn()
		{
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002796")]
		[Address(RVA = "0x33C9E10", Offset = "0x33C8410", VA = "0x1833C9E10")]
		public void TurnOff()
		{
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002797")]
		[Address(RVA = "0x33C9E40", Offset = "0x33C8440", VA = "0x1833C9E40")]
		public void PlayNextSong()
		{
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002798")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryMusicPlayerController()
		{
		}

		// Token: 0x040023D0 RID: 9168
		[Token(Token = "0x40023D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FMODSpectrumData _fmodSpectrumData;

		// Token: 0x040023D1 RID: 9169
		[Token(Token = "0x40023D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _powerSwitchMesh;

		// Token: 0x040023D2 RID: 9170
		[Token(Token = "0x40023D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _songSwitchMesh;

		// Token: 0x040023D3 RID: 9171
		[Token(Token = "0x40023D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _powerClickAudioEvent;

		// Token: 0x040023D4 RID: 9172
		[Token(Token = "0x40023D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[EventRef]
		private string _songClickAudioEvent;

		// Token: 0x040023D5 RID: 9173
		[Token(Token = "0x40023D5")]
		[FieldOffset(Offset = "0x48")]
		private bool _isOverPowerSwitch;

		// Token: 0x040023D6 RID: 9174
		[Token(Token = "0x40023D6")]
		[FieldOffset(Offset = "0x49")]
		private bool _isOverSongSwitch;

		// Token: 0x040023D7 RID: 9175
		[Token(Token = "0x40023D7")]
		[FieldOffset(Offset = "0x50")]
		private MusicPlayerController _musicPlayerController;

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x58")]
		private MeshOutliner _powerSwitchOffOutliner;

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0x60")]
		private MeshOutliner _powerSwitchOnOutliner;

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0x68")]
		private MeshOutliner _songSwitchOutliner;
	}
}
