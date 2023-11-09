# Jellyfin Media Analyzer

## This is a fork of [ConfusedPolarBear Intro Skipper](https://github.com/ConfusedPolarBear/intro-skipper)!

With following changes

- [x] ONLY FOR Jellyfin Server with media segments api!
- [x] Enable Credits detection for episodes and movies (black frame analyzer)
- [x] No cache option (default: enabled) -> no disk space required
- [x] Auto analyze after media scanning task ended
- [x] Filter for tv show names and optional season/s
- [x] No server side playback influence or frontend script injection (clean!)
- [x] Move .edl file creation into another [plugin](<https://github.com/endrl/jellyfin-plugin-edl>)
- [x] Move the extended plugin page for segment edits to a dedicated tool [Media Segment Editor](https://github.com/endrl/segment-editor)
  - [ ] move additional meta support per plugin like "get chromaprints of plugin x"

Analyzes the audio of television episodes to detect intros and cedits, for movies detect credits.

## Requirements

- Jellyfin Server with media segments API!
  - Please read these [instructions](https://github.com/endrl/segment-editor#installation)

## Introduction requirements

Show introductions will only be detected if they are:

- Located within the first 30% of an episode, or the first 15 minutes, whichever is smaller
- Between 15 seconds and 2 minutes long

Ending credits will only be detected if they are shorter than 4 minutes.

All of these requirements can be customized as needed.

## Installation instructions

1. Add plugin repository to your server: `https://raw.githubusercontent.com/endrl/jellyfin-plugin-repo/master/manifest.json`
2. Install the Media Analyzer plugin from the General section
3. Restart Jellyfin
4. Go to Dashboard -> Scheduled Tasks -> Analyze Media and click the play button

## Related projects

- Jellyfin Plugin: [.EDL Creator](https://github.com/endrl/jellyfin-plugin-edl)
- Tool: [Jellyfin Segment Editor](https://github.com/endrl/segment-editor)
- Player: [Jellyfin Vue Fork](https://github.com/endrl/jellyfin-vue)

### Debug Logging

Change your logging.json file to output debug logs for `Jellyfin.Plugin.MediaAnalyzer`. Make sure to add a comma to the end of `"System": "Warning"`

```jsonc
{
    "Serilog": {
        "MinimumLevel": {
            "Default": "Information",
            "Override": {
                "Microsoft": "Warning",
                "System": "Warning",
                "Jellyfin.Plugin.MediaAnalyzer": "Debug"
            }
        }
       // other stuff
    }
}
```
