# Network Interface Manager
#### Easily swap out network configurations on Windows via netsh. 

# Background:

This project originated as part of a bachelor project in 2019. It required frequent adjustments to the network configuration of our PCs, such as switching from DHCP to static IPs, and doing so for multiple network interfaces. To save time, I coded Network Interface Manager, which allows saving and swapping different configurations. It is designed exclusively for Windows, as it utilizes netsh. This repository is not actively maintained and is solely for educational purposes.

# Key Takeaways:
### 1. UI Agnostic Data Handling
   - Data binding using `BindingList` for dynamic data synchronization.
   - Decoupled from the UI.

### 2. Modular UI with Custom ObjectEditor
   - Similar to the Windows Forms Editor (with less noise).
   - Allows for automatic UI generation using serializable objects.

# Preview:

### The Configuration Overview

![The Configuration Overview](./Docs/Interface.png?raw=true "The Configuration Overview")

### Adding a new Configuration (using the ObjectEditor)

![Adding a Config](./Docs/Add%20Config.png?raw=true "Adding a Config")
