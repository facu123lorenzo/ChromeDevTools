using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	///All Permissions Policy features. This enum should match the one defined
	/// in third_party/blink/renderer/core/permissions_policy/permissions_policy_features.json5.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PermissionsPolicyFeature
	{
			Accelerometer,
			[EnumMember(Value = "ambient-light-sensor")]
			Ambient_light_sensor,
			[EnumMember(Value = "attribution-reporting")]
			Attribution_reporting,
			Autoplay,
			Bluetooth,
			[EnumMember(Value = "browsing-topics")]
			Browsing_topics,
			Camera,
			[EnumMember(Value = "captured-surface-control")]
			Captured_surface_control,
			[EnumMember(Value = "ch-dpr")]
			Ch_dpr,
			[EnumMember(Value = "ch-device-memory")]
			Ch_device_memory,
			[EnumMember(Value = "ch-downlink")]
			Ch_downlink,
			[EnumMember(Value = "ch-ect")]
			Ch_ect,
			[EnumMember(Value = "ch-prefers-color-scheme")]
			Ch_prefers_color_scheme,
			[EnumMember(Value = "ch-prefers-reduced-motion")]
			Ch_prefers_reduced_motion,
			[EnumMember(Value = "ch-prefers-reduced-transparency")]
			Ch_prefers_reduced_transparency,
			[EnumMember(Value = "ch-rtt")]
			Ch_rtt,
			[EnumMember(Value = "ch-save-data")]
			Ch_save_data,
			[EnumMember(Value = "ch-ua")]
			Ch_ua,
			[EnumMember(Value = "ch-ua-arch")]
			Ch_ua_arch,
			[EnumMember(Value = "ch-ua-bitness")]
			Ch_ua_bitness,
			[EnumMember(Value = "ch-ua-platform")]
			Ch_ua_platform,
			[EnumMember(Value = "ch-ua-model")]
			Ch_ua_model,
			[EnumMember(Value = "ch-ua-mobile")]
			Ch_ua_mobile,
			[EnumMember(Value = "ch-ua-form-factor")]
			Ch_ua_form_factor,
			[EnumMember(Value = "ch-ua-full-version")]
			Ch_ua_full_version,
			[EnumMember(Value = "ch-ua-full-version-list")]
			Ch_ua_full_version_list,
			[EnumMember(Value = "ch-ua-platform-version")]
			Ch_ua_platform_version,
			[EnumMember(Value = "ch-ua-wow64")]
			Ch_ua_wow64,
			[EnumMember(Value = "ch-viewport-height")]
			Ch_viewport_height,
			[EnumMember(Value = "ch-viewport-width")]
			Ch_viewport_width,
			[EnumMember(Value = "ch-width")]
			Ch_width,
			[EnumMember(Value = "clipboard-read")]
			Clipboard_read,
			[EnumMember(Value = "clipboard-write")]
			Clipboard_write,
			[EnumMember(Value = "compute-pressure")]
			Compute_pressure,
			[EnumMember(Value = "cross-origin-isolated")]
			Cross_origin_isolated,
			[EnumMember(Value = "direct-sockets")]
			Direct_sockets,
			[EnumMember(Value = "display-capture")]
			Display_capture,
			[EnumMember(Value = "document-domain")]
			Document_domain,
			[EnumMember(Value = "encrypted-media")]
			Encrypted_media,
			[EnumMember(Value = "execution-while-out-of-viewport")]
			Execution_while_out_of_viewport,
			[EnumMember(Value = "execution-while-not-rendered")]
			Execution_while_not_rendered,
			[EnumMember(Value = "focus-without-user-activation")]
			Focus_without_user_activation,
			Fullscreen,
			Frobulate,
			Gamepad,
			Geolocation,
			Gyroscope,
			Hid,
			[EnumMember(Value = "identity-credentials-get")]
			Identity_credentials_get,
			[EnumMember(Value = "idle-detection")]
			Idle_detection,
			[EnumMember(Value = "interest-cohort")]
			Interest_cohort,
			[EnumMember(Value = "join-ad-interest-group")]
			Join_ad_interest_group,
			[EnumMember(Value = "keyboard-map")]
			Keyboard_map,
			[EnumMember(Value = "local-fonts")]
			Local_fonts,
			Magnetometer,
			Microphone,
			Midi,
			[EnumMember(Value = "otp-credentials")]
			Otp_credentials,
			Payment,
			[EnumMember(Value = "picture-in-picture")]
			Picture_in_picture,
			[EnumMember(Value = "private-aggregation")]
			Private_aggregation,
			[EnumMember(Value = "private-state-token-issuance")]
			Private_state_token_issuance,
			[EnumMember(Value = "private-state-token-redemption")]
			Private_state_token_redemption,
			[EnumMember(Value = "publickey-credentials-create")]
			Publickey_credentials_create,
			[EnumMember(Value = "publickey-credentials-get")]
			Publickey_credentials_get,
			[EnumMember(Value = "run-ad-auction")]
			Run_ad_auction,
			[EnumMember(Value = "screen-wake-lock")]
			Screen_wake_lock,
			Serial,
			[EnumMember(Value = "shared-autofill")]
			Shared_autofill,
			[EnumMember(Value = "shared-storage")]
			Shared_storage,
			[EnumMember(Value = "shared-storage-select-url")]
			Shared_storage_select_url,
			[EnumMember(Value = "smart-card")]
			Smart_card,
			[EnumMember(Value = "storage-access")]
			Storage_access,
			[EnumMember(Value = "sub-apps")]
			Sub_apps,
			[EnumMember(Value = "sync-xhr")]
			Sync_xhr,
			Unload,
			Usb,
			[EnumMember(Value = "usb-unrestricted")]
			Usb_unrestricted,
			[EnumMember(Value = "vertical-scroll")]
			Vertical_scroll,
			[EnumMember(Value = "web-printing")]
			Web_printing,
			[EnumMember(Value = "web-share")]
			Web_share,
			[EnumMember(Value = "window-management")]
			Window_management,
			[EnumMember(Value = "window-placement")]
			Window_placement,
			[EnumMember(Value = "xr-spatial-tracking")]
			Xr_spatial_tracking,
	}
}
