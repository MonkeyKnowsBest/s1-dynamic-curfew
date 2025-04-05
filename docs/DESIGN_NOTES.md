# Dynamic Night Movement Mod for Schedule I

## Project Overview
A comprehensive mod that transforms the game's nighttime mechanics by introducing a dynamic heat and restriction system that increases gameplay complexity and tension.

## Core Mechanics

### Heat System
- Unseen meter that increases with illegal activities
- Directly influences law enforcement interaction probability
- Rises independently of direct police encounters
- Night-time activities generate additional heat

### Ankle Monitor Mechanism
#### Activation
- Triggered by arrest
- Restricts player movement to the vicinity of owned properties
- Creates a small movement cordon around player-owned locations

### Night-Time Law Enforcement Dynamics
- Significantly increased search and detection probabilities
- Enhanced line of sight and awareness mechanics
- Higher difficulty in hiding contraband during night searches
- Increased overall law enforcement aggression during night hours

### Rehabilitation: Trash Cleanup
- Mechanism to reduce ankle monitor restriction time
- Utilizes existing game monetary system for trash pickup
- Daily caps on monitor time reduction
- Provides players with a method to mitigate movement restrictions

## Technical Implementation

### Core Components
- Heat Tracking System
- Ankle Monitor Management
- Night Movement Controller
- Law Enforcement Interaction Modifier

### Development Environment
- Modding Toolkit: MelonLoader 0.7.0
- Development Platform: Visual Studio
- Target .NET Framework: 4.7.2

## Design Philosophy
Transform nighttime gameplay into a high-stakes, tension-filled experience that demands strategic player decision-making and increases overall game immersion.

## Detailed Mechanism Breakdown

### Heat Generation
- Criminal activities incrementally increase heat
- Night-time activities have multiplied heat generation
- Heat directly impacts:
  - Probability of law enforcement interactions
  - Intensity of searches
  - Duration of potential restrictions

### Ankle Monitor Restrictions
- Movement limited to a small radius around owned properties
- Duration based on:
  - Severity of initial arrest
  - Current heat level
  - Rehabilitation activities (trash cleanup)

### Night-Time Enforcement Enhancements
- Increased law enforcement awareness
- More aggressive search tactics
- Higher detection probability
- Reduced effectiveness of stealth and hiding mechanics

### Trash Cleanup Rehabilitation
- Direct method to reduce ankle monitor time
- Tied to existing in-game trash collection mechanic
- Daily reduction caps prevent exploitation
- Provides alternative to purely punitive system

## Future Considerations
- Continuous mechanic balancing
- Performance optimization
- Community feedback integration
- Potential expansion of rehabilitation mechanics

## Contribution Guidelines
- Open-source development approach
- Modular design for easy updates
- Transparent development process